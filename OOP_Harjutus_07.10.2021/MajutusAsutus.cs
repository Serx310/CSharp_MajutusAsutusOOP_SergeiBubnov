using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus_07._10._2021
{
    public class MajutusAsutus
    {
        protected decimal _hind;
        protected int _kohti;
        protected int _vabukohti;

        public MajutusAsutus(decimal hind, int kohti)
        {
            _hind = hind;
            _kohti = kohti;
            _vabukohti = kohti;
        }

        public virtual int Reserveeri(int külalisi)
        {
            if (külalisi > VabuKohti)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "Ei ole piisavalt vabu kohti");
            }
            if (külalisi < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "Ei tohi olla negatiivne arv");
            }
            VabuKohti -= külalisi;
            return 1;
        }

        public virtual int VabuKohti
        {
            get { return _vabukohti; }
            set { _vabukohti = value; }
        }

        public override string ToString()
        {
            return $"Majutusasutus\nHind: {_hind}\nKohti/Vaba: {_kohti}/{VabuKohti}";
        }

    }
}
