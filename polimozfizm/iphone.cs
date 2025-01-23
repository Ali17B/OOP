using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace polimozfizm
{
    public class iphone
    {
        public void soundplay()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\..\Sounds\iphone.wav"))
            {
                player.Play();
            }
        }

    }
}
