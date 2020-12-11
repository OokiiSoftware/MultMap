using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Windows.Forms;
using MultMap.Auxiliar;
using MultMap.Modelo;
using System.ComponentModel;
using MultMap.Telas.Ferramentas;

namespace MultMap.Telas
{
    public partial class Tela_Ferramentas_Map : Form
    {
        #region Variáveis

        private const string TAG = "Tela_Ferramentas_Map";
        private const string MARKER_TAG = "MarketTemp";

        private bool isMouseDown;
        private bool isMedirDistancias = false;
        private static bool isMapTypeSatelite = false;

        /// <summary>
        /// Armazena distancias dos Markers de <see cref="overlayMarkersDistancia"/>
        /// </summary>
        private List<double> markersDistancias = new List<double>();

        /// <summary>
        /// Nome AutoExplicativo kkk
        /// </summary>
        private List<Caixa> caixasManutencao = new List<Caixa>();
        
        private GMapMarker currentMarker;
        /// <summary>
        /// usado junto com <see cref="overlayMarkersDistancia"/>
        /// pra desenhar linhas no Mapa.
        /// </summary>
        private GMapRoute linhaRoutes = new GMapRoute("Distancia");
        /// <summary>
        /// Todos os Markers referentes a cada Caixa
        /// </summary>
        private GMapOverlay overlayMarkers = new GMapOverlay("markers");
        /// <summary>
        /// DoubleClick no Mapa adiciona Markers temporarios
        /// </summary>
        private GMapOverlay overlayMarkersTemp = new GMapOverlay("markersTemp");
        /// <summary>
        /// Usado pra inserir um Marker no local de uma pesquisa por [latitude, longitude]
        /// </summary>
        private GMapOverlay overlayMarkersPesquisa = new GMapOverlay("pesquisa");
        /// <summary>
        /// Usado pra medir distancias entre Markers e Desenhar a Rota no Mapa
        /// </summary>
        private GMapOverlay overlayMarkersDistancia = new GMapOverlay("CalcularDistancia");

        #endregion

        public Tela_Ferramentas_Map(double lat = 0, double lng = 0)
        {
            InitializeComponent();

            GetCaixas.OnAdd += OnAddCaixa;
            GetCaixas.OnRemove += OnRemoveCaixa;
            GetCaixas.OnAddAll += OnAddAllCaixas;

            Init(lat, lng);
        }

        #region Eventos

        private void Tela_Ferramentas_Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                GetCaixas.OnAdd -= OnAddCaixa;
                GetCaixas.OnRemove -= OnRemoveCaixa;
                GetCaixas.OnAddAll -= OnAddAllCaixas;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void On_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                BringToFront();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Adiciona ou atualiza o Marker referente ao item
        /// </summary>
        private void OnAddCaixa(Caixa item)
        {
            if (item.isEditado)
            {
                if (map.InvokeRequired)
                {
                    map.Invoke(new Action(() =>
                    {
                        AlterarMarker(item);
                    }));
                }
                else
                {
                    AlterarMarker(item);
                }
            }
            else
            {
                if (map.InvokeRequired)
                {
                    map.Invoke(new Action(() =>
                    {
                        AddMarkers(item);
                    }));
                }
                else
                {
                    AddMarkers(item);
                }
            }

            VerificarManutencao(item);
            //setMapPosition(map.Position);
        }

        /// <summary>
        /// Remove o Marker referente ao item
        /// </summary>
        private void OnRemoveCaixa(Caixa item)
        {
            RemoverMarker(item);
        }

        /// <summary>
        /// Limpa o mapa e adiciona todos os Markers
        /// </summary>
        private void OnAddAllCaixas(List<Caixa> items)
        {
            overlayMarkers.Markers.Clear();
            foreach (var item in items)
                if (map.InvokeRequired)
                {
                    map.Invoke(new Action(() =>
                    {
                        AddMarkers(item);
                    }));
                }
                else
                {
                    AddMarkers(item);
                }
            //setMapPosition(map.Position);
        }

        #region Map

        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            OnMarkerClick(item, e);
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            OnMapMouseClick(e);
        }

        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = true;
        }
        
        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left && isMouseDown)
                {
                    if (currentMarker != null)
                    {
                        PointLatLng pnew = map.FromLocalToLatLng(e.X, e.Y);
                        currentMarker.Position = pnew;
                        currentMarker.ToolTipText = GetToolTipText(pnew);

                        AtualizarOverlayRoutes();
                    }
                    map.Refresh();
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                isMouseDown = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Map_OnMarkerEnter(GMapMarker item)
        {
            try
            {
                if (item.Tag != null)
                    if (item.Tag.Equals(MARKER_TAG))
                        currentMarker = item;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }
        
        private void Map_OnMarkerLeave(GMapMarker item)
        {
            try
            {
                currentMarker = null;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnMapDoubleClick(e);
        }

        #region map ações

        private void OnMapMouseClick(MouseEventArgs e)
        {
            try
            {
                BringToFront();
                if (e.Button == MouseButtons.Right)
                    OnRemoverOverlayLinhas();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Remove todas as Linhas de Routes no Mapa
        /// </summary>
        private void OnRemoverOverlayLinhas()
        {
            overlayMarkersDistancia.Routes.Clear();
            overlayMarkersDistancia.Markers.Clear();
            linhaRoutes.Clear();
            markersDistancias.Clear();

            txt_Log.Visible = false;
        }

        /// <summary>
        /// Adiciona marcadores temporários
        /// </summary>
        private void OnMapDoubleClick(MouseEventArgs e)
        {
            try
            {
                PointLatLng position = map.FromLocalToLatLng(e.X, e.Y);

                GMapMarker marker = new GMarkerGoogle(position, GMarkerGoogleType.black_small)
                {
                    Tag = MARKER_TAG,
                    ToolTipText = GetToolTipText(position)
                };
                overlayMarkersTemp.Markers.Add(marker);

                if (!btn_Remover_Marcadores_Temporarios.Visible)
                    btn_Remover_Marcadores_Temporarios.Visible = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (isMedirDistancias)
                    {
                        // só adiciona se não tiver na lista
                        if (!overlayMarkersDistancia.Markers.Contains(item))
                        {
                            overlayMarkersDistancia.Markers.Add(item);// Add item (n..)
                            AtualizarOverlayRoutes();
                        }
                    }
                    else
                    {
                        cb_Calcular_Distancia.Visible = true;
                        overlayMarkersDistancia.Markers.Clear();
                        overlayMarkersDistancia.Markers.Add(item);// <- Add o primeiro Item
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

        #region Botões

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            OnAtualizar();
        }

        private void Btn_map_type_Click(object sender, EventArgs e)
        {
            OnSwithMapType();
        }
        
        private void Btn_remover_marcadores_temporarios_Click(object sender, EventArgs e)
        {
            OnRemoverMarcadoresTemporarios();
        }

        private void Cb_calcular_distancia_CheckedChanged(object sender, EventArgs e)
        {
            isMedirDistancias = cb_Calcular_Distancia.Checked;
        }

        private void CB_Manutencao_Click(object sender, EventArgs e)
        {
            Flow_CaixasManutencao.Visible = CB_Manutencao.Selecionado;
        }

        #region Ações dos botões

        private async void OnAtualizar()
        {
            try
            {
                txt_Log.Visible = true;
                GetCaixas.AddAll(await Caixa.BaixarLista());
                txt_Log.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void OnRemoverMarcadoresTemporarios()
        {
            try
            {
                overlayMarkersTemp.Markers.Clear();
                OnRemoverOverlayLinhas();

                isMedirDistancias =
                cb_Calcular_Distancia.Visible =
                cb_Calcular_Distancia.Checked =
                btn_Remover_Marcadores_Temporarios.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Alterna entre os tipos de mapa (Mapa normal ou satelite)
        /// </summary>
        private void OnSwithMapType()
        {
            isMapTypeSatelite = !isMapTypeSatelite;
            try
            {
                if (isMapTypeSatelite)
                {
                    btn_Map_Type.Text = "Mapa";
                    map.MapProvider = GMapProviders.GoogleSatelliteMap;
                }
                else
                {
                    btn_Map_Type.Text = "Satelite";
                    map.MapProvider = GMapProviders.GoogleMap;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        #endregion

        #endregion

        #region TextBox

        private void Tb_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Pesquisar();
        }
        
        private void Tb_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnPesquisa_KeyPress(e);
        }

        private void OnPesquisa_KeyPress(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void Pesquisar()
        {
            var pesquisa = Tb_Pesquisa.Text.Trim();
            if (pesquisa.Trim().Length == 0) return;

            try
            {
                /// Pesquisa por uma caixa que contenha no Nome a "pesquisa"
                var item = GetCaixas.data.Find(x => x.nome.Contains(pesquisa));
                if (item != null)
                {
                    Pesquisar(item.latitude, item.longitude, isPesquisaExterna: true);
                    return;
                }

                // Pesquisa Latitude Longitude
                var posicao = Transformar(pesquisa);
                var latLng = posicao.Split('.');
                double lat = Convert.ToSingle(latLng[0]);
                double lng = Convert.ToSingle(latLng[1]);
                Pesquisar(lat, lng);
            }
            catch(Exception ex)
            {
                Log.Erro(TAG, ex);
            }

        }

        #endregion

        #endregion

        #region Métodos

        private void Init(double lat, double lng)
        {
            CarregarTema();
            try
            {
                GMapProviders.GoogleMap.ApiKey = @"AIzaSyC6rV9e2_eXcVejnMdPAc-SxRIUCi0IspA";
                GMaps.Instance.Mode = AccessMode.ServerAndCache;
                map.MapProvider = GMapProviders.GoogleMap;
                map.DisableFocusOnMouseEnter = true;
                
                //controlar com mouse
                map.DragButton = MouseButtons.Left;

                overlayMarkersDistancia.Routes.Add(linhaRoutes);

                map.Overlays.Add(overlayMarkers);
                map.Overlays.Add(overlayMarkersTemp);
                map.Overlays.Add(overlayMarkersPesquisa);
                map.Overlays.Add(overlayMarkersDistancia);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                MessageBox.Show("Ocorreu um erro ao abrir o mapa");
            }

            OnSwithMapType();
            try
            {
                //AtualizarDoFirebase();
                OnAtualizar();

                if (lat != 0 && lng != 0)
                {
                    // true indica que não é uma pesquisa feita nesta tela
                   Pesquisar(lat, lng, true);
                }
                else
                    setMapPosition(new PointLatLng(-2.534761, -44.218683));
                //FirebaseObservable = GetFirebaseOrservable();
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void CarregarTema()
        {
            try
            {
                #region BackColor

                BackColor = TemaConfig.ColorPrimary;
                Tb_Pesquisa.BackColor = TemaConfig.ColorPrimaryDark;

                #endregion

                #region ForeColor

                ForeColor = TemaConfig.TextColorPrimary;
                Tb_Pesquisa.ForeColor = TemaConfig.TextColorPrimary;

                #endregion
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Pesquisar Localização pela Latitude e Longitude
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lng">Longitude</param>
        /// <param name="isPesquisaExterna">Se for [false] adiciona um Marcador no mapa</param>
        public void Pesquisar(double lat, double lng, bool isPesquisaExterna = false)
        {
            try
            {
                PointLatLng location = new PointLatLng(lat, lng);

                setMapPosition(location);
                map.Zoom = map.MaxZoom;
                if (isPesquisaExterna) // <- Se TRUE não insere um Marker no Mapa
                    return;

                GMapMarker marcador = new GMarkerGoogle(location, GMarkerGoogleType.yellow_dot)
                {
                    ToolTipText = "Novo"
                };

                overlayMarkersPesquisa.Markers.Clear();
                overlayMarkersPesquisa.Markers.Add(marcador);
                //acula:
                //setMapPosition(map.Position);
            }
            catch (Exception ex)
            {
                Import.Alert(txt_Log, "Insira uma localização válida", isErro: true);
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// organiza a localização de forma que o mapa consiga ler
        /// </summary>
        private string Transformar(string texto)
        {
            string novoTexto = "";
            try
            {
                for (int y = 0; y < texto.Length; y++)
                {
                    char x = texto[y];
                    switch (x)
                    {
                        case '.':
                            x = ',';
                            break;
                        case ',':
                            x = '.';
                            break;
                    }
                    novoTexto += x;
                }
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
            return novoTexto;
        }

        /// <summary>
        /// Retorna a distancia entre dois marcadores
        /// </summary>
        /// <param name="p1">Início</param>
        /// <param name="p2">Fim</param>
        private double GetDistance(PointLatLng p1, PointLatLng p2)
        {
            double distance = 0;
            try
            {
                GeoCoordinate item1 = new GeoCoordinate(p1.Lat, p1.Lng);
                GeoCoordinate item2 = new GeoCoordinate(p2.Lat, p2.Lng);
                distance = item1.GetDistanceTo(item2);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }

            return distance;
        }

        /// <summary>
        /// Soma a distancia dos Markers incluidos na lista "overlayMarkersDistancia" e mostra o valor na tela.
        /// Desenha a rota entre todos os Markers
        /// </summary>
        private void AtualizarOverlayRoutes()
        {
            try
            {
                linhaRoutes.Clear();
                overlayMarkersDistancia.Routes.Clear();

                double distancia = 0;
                for (int i = 0; i < overlayMarkersDistancia.Markers.Count - 1; i++)
                {
                    var pointInicio = overlayMarkersDistancia.Markers[i].Position;
                    var pointFim = overlayMarkersDistancia.Markers[i + 1].Position;
                    distancia += GetDistance(pointInicio, pointFim);
                    DesenharRoute(pointInicio, pointFim);
                }

                txt_Log.Visible = true;
                txt_Log.Text = string.Format("{0:00.##} m", distancia);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        /// <summary>
        /// Desenha uma linha no Mapa entre os Dois (2) pontos
        /// </summary>
        /// <param name="p1">Inicio</param>
        /// <param name="p2">Fim</param>
        private void DesenharRoute(PointLatLng p1, PointLatLng p2)
        {
            linhaRoutes.Stroke = new Pen(Brushes.Red, 2);// largura e cor da linha
            linhaRoutes.Points.Add(p1);
            linhaRoutes.Points.Add(p2);

            overlayMarkersDistancia.Routes.Add(linhaRoutes);
            map.UpdateRouteLocalPosition(linhaRoutes);
        }

        private string GetToolTipText(PointLatLng location)
        {
            try
            {
                return string.Format("Lat: {0}\nLng: {1}", location.Lat, location.Lng);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return "";
            }
        }
        
        /// <summary>
        /// Reseta todas as variáveis temporarias.
        /// </summary>
        private void ResetMapa()
        {
            try
            {
                txt_Log.Visible =
                isMedirDistancias =
                cb_Calcular_Distancia.Checked =
                cb_Calcular_Distancia.Visible = false;

                setMapPosition(map.Position);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void setMapPosition(PointLatLng point)
        {
            if (map.InvokeRequired)
            {
                map.Invoke(new Action(() =>
                {
                    map.Position = point;
                }));
            }
            else
            {
                map.Position = point;
            }
        }

        #region Caixa

        /// <summary>
        /// Verifica se o item está em manutencao e atualiza o Layou 
        /// </summary>
        private void VerificarManutencao(Caixa item)
        {
            var itemRemover = caixasManutencao.Find(x => x.id.Equals(item.id));

            if (itemRemover == null && item.isEmManutencao)
            {
                caixasManutencao.Add(item);
                if (GetButton(item) == null)
                    GetInvoker.ContainerEmManutencao(
                        flowGradiente: Flow_CaixasManutencao,
                        painelAlerta: Painel_Alerta_Manutencao,
                        caixa: item,
                        onClick: (s, e) => Pesquisar(item.latitude, item.longitude, isPesquisaExterna: true));
            }
            else if (itemRemover != null && !item.isEmManutencao)
            {
                var bt = GetButton(item);
                if (bt != null) GetInvoker.chara(Flow_CaixasManutencao, Painel_Alerta_Manutencao, CB_Manutencao, bt);

                caixasManutencao.Remove(itemRemover);
            }
        }

        private Button GetButton(Caixa item)
        {
            foreach (Button b in Flow_CaixasManutencao.Controls)
                if (b.Text.Equals(item.nome))
                {
                    return b;
                }
            return null;
        }

        #endregion

        #region Marker

        private void AddMarkers(Caixa item)
        {
            try
            {
                GMarkerGoogleType icon = GetMarkerIcon(item);
                var marker = new GMarkerGoogle(new PointLatLng(item.latitude, item.longitude), icon)
                {
                    ToolTipText = item.nome + " (" + item.pon.ToString() + ")"
                };

                overlayMarkers.Markers.Add(marker);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
            }
        }

        private void AlterarMarker(Caixa item)
        {
            if (RemoverMarker(item))
                AddMarkers(item);
        }

        private bool RemoverMarker(Caixa item)
        {
            try
            {
                Log.Msg(TAG, "RemoverMarker", "Init");
                var markerAux = FindMarker(item);
                if (markerAux == null) return false;

                Log.Msg(TAG, "RemoverMarker", "OK");
                return overlayMarkers.Markers.Remove(markerAux);
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return false;
            }
        }

        /// <summary>
        /// Pesquisa um Marker em todos os Overlays do Mapa que tenha a mesma localização do Item.
        /// </summary>
        private GMapMarker FindMarker(Caixa item)
        {
            foreach(var overlay in map.Overlays)
            {
                foreach(var marker in overlay.Markers)
                    if (marker.Position.Lat == item.latitude && marker.Position.Lng == item.longitude)
                    {
                        return marker;
                    }
            }
            return null;
            //return markers.Find(x => (x.Position.Lat == item.latitude) && x.Position.Lng == item.longitude);
        }

        /// <summary>
        /// Retorna um Marcador com a cor de acordo com algumas condições.
        /// </summary>
        private GMarkerGoogleType GetMarkerIcon(Caixa item)
        {
            try
            {
                if (item.isEmManutencao)
                    return item.pon == Caixa.PonType.GPon ? GMarkerGoogleType.orange_dot : GMarkerGoogleType.orange;
                if (item.status.Equals("CHEIO"))
                    return item.pon == Caixa.PonType.GPon ? GMarkerGoogleType.red_dot : GMarkerGoogleType.red;
                else
                    return item.pon == Caixa.PonType.GPon ? GMarkerGoogleType.blue_dot : GMarkerGoogleType.green;
            }
            catch (Exception ex)
            {
                Log.Erro(TAG, ex);
                return GMarkerGoogleType.arrow;
            }
        }

        #endregion

        #endregion

        static class GetInvoker
        {
            public static void ContainerEmManutencao(FlowGradiente flowGradiente, PanelGradient painelAlerta, Caixa caixa, EventHandler onClick)
            {
                if (flowGradiente.InvokeRequired)
                {
                    flowGradiente.Invoke(new Action(() =>
                    {
                        ContainerEmManutencaoAux(flowGradiente, painelAlerta, caixa, onClick);
                    }));
                }
                else ContainerEmManutencaoAux(flowGradiente, painelAlerta, caixa, onClick);
            }
            /// <summary>
            /// Metodo Auxiliar pra diminuir linhas do código.
            /// </summary>
            private static void ContainerEmManutencaoAux(FlowGradiente flowGradiente, PanelGradient painelAlerta, Caixa caixa, EventHandler onClick)
            {
                var bt = NewButton(caixa, onClick);
                painelAlerta.Visible = true;
                flowGradiente.Controls.Add(bt);
                if (flowGradiente.Size.Height < flowGradiente.MaximumSize.Height)
                    flowGradiente.Size = new Size(flowGradiente.Width, flowGradiente.Height + bt.Height + bt.Margin.Top * 2);
            }

            private static Button NewButton(Caixa item, EventHandler onClick)
            {
                var b = new Button
                {
                    Size = new Size(155, 28),
                    Text = item.nome,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat
                };
                b.FlatAppearance.BorderSize = 0;
                b.Click += onClick;
                return b;
            }

            /// <summary>
            /// Não consegui pensar em um nome pra esse método.
            /// Ele atualiza o Layout 
            /// </summary>
            public static void chara(FlowGradiente flowGradiente, PanelGradient painelAlerta, CustomCheckBox checkBox, Button button)
            {
                if (flowGradiente.InvokeRequired)
                {
                    flowGradiente.Invoke(new Action(() =>
                    {
                        charaAux(flowGradiente, painelAlerta, checkBox, button);
                    }));
                }
                else charaAux(flowGradiente, painelAlerta, checkBox, button);
            }
            /// <summary>
            /// Metodo Auxiliar pra diminuir linhas do código.
            /// </summary>
            private static void charaAux(FlowGradiente flowGradiente, PanelGradient painelAlerta, CustomCheckBox checkBox, Button button)
            {

                flowGradiente.Controls.Remove(button);
                painelAlerta.Visible = flowGradiente.Controls.Count > 0;
                flowGradiente.Visible = checkBox.Selecionado && flowGradiente.Controls.Count > 0;
                flowGradiente.Size = new Size(flowGradiente.Width, flowGradiente.Height - button.Height - button.Margin.Top * 2);

                if (!painelAlerta.Visible)
                    checkBox.Selecionado = false;
            }
        }

    }
}
