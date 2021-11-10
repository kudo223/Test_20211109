using System;
using System.Collections.Generic;
using System.Text;

namespace Test_20211109
{
    class Ucet
    {
        //mně se smazal ten formulář
        //otevřel jsem program na jiném školním počítači a ten formulář zde byl, ale byla zde 1 chyba, tak jsem ji opravil ale je zde stará verze visual studia, takže to nešlo dát na git, tak jsem kód upravil přímo na gitu
        public string jmeno;
        public int stav;
        public int max = 200000;

        public Ucet(string jmeno, int stav)
        {
            this.jmeno = jmeno;
            this.stav = stav;
        }
        public void Vlozit(int vlozeni)
        {
            if (stav + vlozeni > max)
            {
                System.Windows.Forms.MessageBox.Show("Přesáhl jste limit. Tuto částku nelze vložit.");
            }
            else
            {
                stav += vlozeni;
                System.Windows.Forms.MessageBox.Show($"Vložil jste {vlozeni}$.");
            }
        }
        public void Vyber(int vybrani)
        {
            if (stav - vybrani < 0)
            {
                System.Windows.Forms.MessageBox.Show("Takovou částku z vašeho účtu nelze vybrat.");
            }
            else
            {
                stav -= vybrani;
                System.Windows.Forms.MessageBox.Show($"Vybral jste {vybrani}");
            }
        }
        public void Platba(int placeni)
        {
            if (stav - placeni < 0)
            {
                System.Windows.Forms.MessageBox.Show("Na takovou částku nemáte dostatek financí.");
            }
            else
            {
                stav -= placeni;
                System.Windows.Forms.MessageBox.Show($"Platil jste za {placeni}");
            }
        }
    }
}
