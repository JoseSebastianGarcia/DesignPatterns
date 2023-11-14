using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Structure.Facade
{
    public class Facade : IFacade
    {
        private readonly ComplexAudioSubsystem _audio;
        private readonly ComplexVideoSubsystem _video;
        public Facade(ComplexAudioSubsystem audio, ComplexVideoSubsystem video) 
        {
            _audio = audio;
            _video = video;
        }

        public void Run()
        {
            string videoState = _video.RenderVideo(_audio.AsembleAudio());
            Console.WriteLine(videoState);
        }
    }
}
