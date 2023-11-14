using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Design_Patterns.Decorator;

namespace DesignPatterns.Views.Design_Patterns
{
    public class DecoratorView : IView
    {
        public void Render()
        {
            Console.Clear();

            SmsComponent smsComponent = new SmsComponent();

            smsComponent.Send("Solo sms");

            Console.WriteLine();

            FacebookComponent faceComponent = new FacebookComponent();
            faceComponent.Send("Solo facebook");

            Console.WriteLine();

            SlackComponent slackComponent = new SlackComponent();
            slackComponent.Send("Solo slack");

            Console.WriteLine();

            FacebookComponent facebookComponent = new FacebookComponent(new SlackComponent());
            facebookComponent.Send("Por facebook y slack");

            Console.WriteLine();

            SmsComponent smsComponentCombined = new SmsComponent(new FacebookComponent());
            smsComponentCombined.Send("Por sms y facebook");

            Console.WriteLine();

            SmsComponent allCombined = new SmsComponent(new FacebookComponent(new SlackComponent()));
            allCombined.Send("Por todos los medios");

            Console.ReadKey();
        }
    }
}
