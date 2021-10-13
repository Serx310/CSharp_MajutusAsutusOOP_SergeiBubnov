using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus_07._10._2021
{
    public class Hotell : MajutusAsutus
    {
        private int _tubadearv;
        private int _kohtitoas;
        public Hotell(decimal hind, int kohtiToas, int tubadeArv) : base(hind, tubadeArv*kohtiToas) {
            _kohtitoas = kohtiToas;
            _tubadearv = tubadeArv;
        }

        public override int Reserveeri(int külalisi)
        {
            if (külalisi > VabuTube)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "Ei ole piisavalt vabu kohti");
            }
            if (külalisi < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "Ei tohi olla negatiivne arv");
            }
            int tubeVaja = (int)Math.Ceiling((double)külalisi / _kohtitoas);
            VabuTube -= külalisi;
            return VabuTube;
        }

        public override int VabuKohti
        {
            get => VabuTube * _kohtitoas;
            set { VabuTube = (int)Math.Ceiling((double)value / _kohtitoas); }
        }

        public int VabuTube
        {
            get { return _tubadearv; }
            set { _tubadearv = value; }
        }
    }
}
