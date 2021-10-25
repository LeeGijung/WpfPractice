using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Exercise_1.StartAssets
{
    class Talk : ObservableCollection<Message>
    {
        public Talk()
        {
            this.Add(new Message() { Sender = "Adventure Works", Content = "Hi, What Can we do for you?" });
            this.Add(new Message() { Sender = "Client", Content = "Did you receive the GR268 KZ bike?" });
        }
    }

    class Message
    {
        public string Sender { get; set; }
        public string Content { get; set; }
    }

}
