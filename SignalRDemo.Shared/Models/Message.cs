using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRDemo.Shared.Models
{
    public class Message
    {
        private string _id;
        public Message()
        {
            _id = Guid.NewGuid().ToString();
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }

        public string Body
        {
            get; set;
        }

    }
}
