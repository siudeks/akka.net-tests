using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public sealed class GreetingActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
        }

        public sealed class WelcomeQuery {

            public string Name { get; private set; }

            public WelcomeQuery(string name) => this.Name = name;
        }

        public sealed class WelcomeReply
        {
            public string Response { get; private set; }
            public WelcomeReply(string response) => Response = response;
        }



    }
}
