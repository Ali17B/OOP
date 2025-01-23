using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace polimozfizm
{
    public class Samsung
    {

        public void soundplay()
        {
            //Enviroment classı programın çalıştığı ortam ile ilgili bilgileri tutar. CurrentDirectory ile programın çalıştığı dizini alırız.

            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\..\Sounds\samsung.wav"))
            {
                player.Play();
            }
        }
    }
}
