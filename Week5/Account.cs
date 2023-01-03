using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Account
    {
        //Latihan A
        private string _nama;
        private string _jantina;
        
        public void SetNama(string namaAkaun)
        {
            _nama = namaAkaun;
        }

        public string GetNama()
        {
            return _nama; 
        }

        public void SetJantina(string jantina)
        {
            _jantina = jantina;
        }

        public string GetJantina()
        {
            return _jantina;
        }
        //Latihan B
        public string Nama
        {
            get => _nama;
          
            set =>_nama = value;

        }

        public string Jantina
        {
            get => _jantina;

            set => _jantina = value;

        }

    }

    class AutoAccount
    {
        //Latihan C
        public string Nama { get; set; } = "Syahmi";
    }

    class LatihanD
    {
        public string Nama { get; set; }
        public string strBaki { get; set; }
        public int intBakiAwal { get; set; }
        public int intBaki { get; set; } = 0;

        public void Deposit(int v1)
        {
            intBaki += v1;

        }

        public void Withdraw(int v1,int v2)
        {
            if (v1 <= 0)
                throw new Exception("Insert a positive number please!");
            else if (v1 > v2)
                throw new Exception("Withdrawing more than balance!");
            else
                intBaki -= v1;

          


        }

    }
}
