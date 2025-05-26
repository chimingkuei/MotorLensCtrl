using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit.Zoombox;

namespace MotorLensCtrl
{
    #region Config Class
    public class SerialNumber
    {
        [JsonProperty("Parameter1_val")]
        public string Parameter1_val { get; set; }
        [JsonProperty("Parameter2_val")]
        public string Parameter2_val { get; set; }
    }

    public class Model
    {
        [JsonProperty("SerialNumbers")]
        public SerialNumber SerialNumbers { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("Models")]
        public List<Model> Models { get; set; }
    }
    #endregion

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Function
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("請問是否要關閉？", "確認", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Config
        private SerialNumber SerialNumberClass()
        {
            SerialNumber serialnumber_ = new SerialNumber
            {
                Parameter1_val = Parameter1.Text,
                Parameter2_val = Parameter2.Text
            };
            return serialnumber_;
        }

        private void LoadConfig(int model, int serialnumber, bool encryption = false)
        {
            List<RootObject> Parameter_info = Config.Load(encryption);
            if (Parameter_info != null)
            {
                Parameter1.Text = Parameter_info[model].Models[serialnumber].SerialNumbers.Parameter1_val;
                Parameter2.Text = Parameter_info[model].Models[serialnumber].SerialNumbers.Parameter2_val;
            }
            else
            {
                // 結構:2個Models、Models下在各2個SerialNumbers
                SerialNumber serialnumber_ = SerialNumberClass();
                List<Model> models = new List<Model>
                {
                    new Model { SerialNumbers = serialnumber_ },
                    new Model { SerialNumbers = serialnumber_ }
                };
                List<RootObject> rootObjects = new List<RootObject>
                {
                    new RootObject { Models = models },
                    new RootObject { Models = models }
                };
                Config.SaveInit(rootObjects, encryption);
            }
        }

        private void SaveConfig(int model, int serialnumber, bool encryption = false)
        {
            Config.Save(model, serialnumber, SerialNumberClass(), encryption);
        }
        #endregion

        #region Dispatcher Invoke 
        public string DispatcherGetValue(System.Windows.Controls.TextBox control)
        {
            string content = "";
            this.Dispatcher.Invoke(() =>
            {
                content = control.Text;
            });
            return content;
        }

        public void DispatcherSetValue(string content, System.Windows.Controls.TextBox control)
        {
            this.Dispatcher.Invoke(() =>
            {
                control.Text = content;
            });
        }
        #endregion

        public void SetSliderStyle(Slider slider, TextBlock sliderMin, TextBlock sliderMax, int min, int max)
        {
            slider.Minimum = min;
            slider.Maximum = max;
            sliderMin.Text = min.ToString();
            sliderMax.Text = max.ToString();
            slider.TickPlacement = TickPlacement.None;
        }
        #endregion

        #region Parameter and Init
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Parameter1.Visibility = Visibility.Collapsed;
            Parameter2.Visibility = Visibility.Collapsed;
            LoadConfig(0, 0);
        }
        BaseConfig<RootObject> Config = new BaseConfig<RootObject>();
        Core Do = new Core();
        #region Log
        BaseLogRecord Logger = new BaseLogRecord();
        //Logger.WriteLog("儲存參數!", LogLevel.General, richTextBoxGeneral);
        #endregion
        #endregion

        #region Main Screen
        private void Main_Btn_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as System.Windows.Controls.Button).Name)
            {
                case nameof(Connet):
                    {
                        Do.Connet();
                        break;
                    }
                case nameof(MotorLensInit):
                    {
                        var zoomRange = Do.GetZoomValue();
                        int zoomMin = zoomRange["ZoomMin"];
                        int zoomMax = zoomRange["ZoomMax"];
                        SetSliderStyle(Zoom_Slider, Zoom_Slider_Min, Zoom_Slider_Max, zoomMin, zoomMax);
                        var focusRange = Do.GetFocusValue();
                        int focusMin = focusRange["FocusMin"];
                        int focusMax = focusRange["FocusMax"];
                        SetSliderStyle(Focus_Slider, Focus_Slider_Min, Focus_Slider_Max, focusMin, focusMax);
                        var irisRange = Do.GetIrisValue();
                        int irisMin = irisRange["IrisMin"];
                        int irisMax = irisRange["IrisMax"];
                        SetSliderStyle(Iris_Slider, Iris_Slider_Min, Iris_Slider_Max, irisMin, irisMax);
                        break;
                    }
            }
        }

        private void MotorLensCtrl_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider)
            {
                ushort value = (ushort)slider.Value;
                switch (slider.Name)
                {
                    case "Zoom_Slider":
                        Do.SetZoomValue(value);
                        break;

                    case "Focus_Slider":
                        Do.SetFocusValue(value);
                        break;

                    case "Iris_Slider":
                        Do.SetIrisValue(value);
                        break;
                }
            }
        }
        #endregion

    }
}
