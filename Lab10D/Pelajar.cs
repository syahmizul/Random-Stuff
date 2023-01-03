using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10CandD
{
    class Pelajar
    {
        public string Nama { get; }
        public string NoMatrik { get; }
        public int Umur { get; set; }

        private int markah;


        public Pelajar(string nama,string noMatrik,int markah,int umur)
        {
            Nama = nama;
            NoMatrik = noMatrik;
            Markah = markah;
            Umur = umur;
        }

        public int Markah
        {
            get => markah;
            set
            {
                if(markah >= 0)
                {
                    markah = value;
                }
            }
        }

        

        public int UmurRestricted

        {
            get
            {
                if (Umur >= 19 && Umur <= 24)
                    return Umur;
                else
                    return 0;

            }
        }

        public override string ToString()
        {
            return $"Nama : {Nama} \nNo Matrik: {NoMatrik} \nMarkah: {Markah}\nUmur : {Umur}\n\n";
        }
    }
}
