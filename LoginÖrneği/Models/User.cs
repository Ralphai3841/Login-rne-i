using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginÖrneği.Models
{
    public class User                 // ilk olarak classın başına public yazarız. // sonra class'ın içine özelliklerimizi yazarız.
    {
        public string userName { get; set; }        // prop yazıp iki kez tab'a basıp property oluştururuz. get ve st metotlar . propertymizin ismi userName. get getirmek set set etmek yükelmek
        public string password { get; set; }        // propertyler yarı metot gibidir.
        public int age { get; set; }
        public string job { get; set; }

        public void Login(string loginDate)         //logindate = giriş tarihi
        {
            System.Windows.Forms.MessageBox.Show($"{loginDate} tarihinde {userName} adlı kullanıcı " +
                $"{password} şifresi ile giriş yapmıştır. ");   //system kütüphanesinden messagenox'ı aldık. sıra sıra gitti .
        }

    }
}


// kullanıcı ne yapabilir sorusuna cevap arıyoruz -> kullanıcı login olabilir.
//kullanıcı login olabilir cevabı vererek metot oluşturacaz.
