using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MotorLensCtrl
{
    class Core
    {
        private void ZoomInitiation()
        {
            LensCtrl.Instance.ZoomParameterReadSet();
            LensCtrl.Instance.ZoomInit();
        }

        private void FocusInitiation()
        {
            LensCtrl.Instance.FocusParameterReadSet();
            LensCtrl.Instance.FocusInit();
        }

        private void IrisInitiation()
        {
            LensCtrl.Instance.IrisParameterReadSet();
            LensCtrl.Instance.IrisInit();
        }

        public void Connet()
        {
            LensCtrl.Instance.UsbOpen(0);
            ZoomInitiation();
            FocusInitiation();
            IrisInitiation();
        }

        public Dictionary<string, int> GetZoomValue()
        {
            int min = LensCtrl.Instance.zoomMinAddr;
            int max = LensCtrl.Instance.zoomMaxAddr;
            Console.WriteLine($"Zoom Min: {min}");
            Console.WriteLine($"Zoom Max: {max}");
            return new Dictionary<string, int>
            {
                { "ZoomMin", min },
                { "ZoomMax", max }
            };
        }

        public void SetZoomValue(ushort zoom)
        {
            LensCtrl.Instance.ZoomMove(zoom);
        }

        public Dictionary<string, int> GetFocusValue()
        {
            int min = LensCtrl.Instance.focusMinAddr;
            int max = LensCtrl.Instance.focusMaxAddr;
            Console.WriteLine($"Focus Min: {min}");
            Console.WriteLine($"Focus Max: {max}");
            return new Dictionary<string, int>
            {
                { "FocusMin", min },
                { "FocusMax", max }
            };
        }

        public void SetFocusValue(ushort focus)
        {
            LensCtrl.Instance.FocusMove(focus);
        }

        public Dictionary<string, int> GetIrisValue()
        {
            int min = LensCtrl.Instance.irisMinAddr;
            int max = LensCtrl.Instance.irisMaxAddr;
            Console.WriteLine($"Iris Min: {min}");
            Console.WriteLine($"Iris Max: {max}");
            return new Dictionary<string, int>
            {
                { "IrisMin", min },
                { "IrisMax", max }
            };
        }

        public void SetIrisValue(ushort iris)
        {
            LensCtrl.Instance.IrisMove(iris);
        }



    }
}
