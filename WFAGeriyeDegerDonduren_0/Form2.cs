using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAGeriyeDegerDonduren_0
{
    public partial class Form2 : Form
    {

        /*
         
            Parametre alan metotlarda istediginiz takdirde bu parametrelerin varsayılan degerlerini metotları olustururken de verebilirsiniz...Böylece metodu cagırırken eger o parametreye uygun bir argüman vermezseniz metot, varsayılan parametre degerini argüman olarak alacaktır....Ancak dilediginiz takdirde argüman da vererek varsayılan degeri ezip kendi argümanınızı gönderebilirsiniz...

        Eger bir metodun parametrelerinin varsayılan degeri yazılmıssa bu metodu cagırdıgınız zaman argüman vermek zorunda kalmazsınız...O zaman metot, parametrelerinin varsayılan degerini argüman olarak atayacaktır...Argüman verirseniz de varsayılan degerler yerine sizin verdiginiz argümanlar alınır...
         
         Eger bir parametrenin defaul value'su var ise default value'su olmayan parametreler ondan sonra yazılamaz(önce bulunması gerekir)
         */

        public Form2()
        {
            InitializeComponent();
        }


        public void Selamla(string isim = "Cagri",int yas = 37)
        {
            MessageBox.Show($"Hosgeldin {isim}");
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Selamla(yas:27);

        }
    }
}
