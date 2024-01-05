using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casi;
        private int sobaihat;
        private int donggia;

        public CD()
        {
        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casi, int sobaihat, int donggia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casi = casi;
            this.sobaihat = sobaihat;
            this.donggia = donggia;

        }
        public int MACD
        {
            set { this.macd = value;  }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value;  }
            get { return tuacd; }
        }
        public string Casi
        {
            set { this.casi = value; }
            get { return casi; }
        }
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public int DongGia
        {
            set { this.donggia = value; }
            get { return donggia; }
        }
        public string Tostring()
        {
            return string.Format("{0} {1} {2} {3} {4}", macd, tuacd, casi, sobaihat, donggia);
        }
    }
}
