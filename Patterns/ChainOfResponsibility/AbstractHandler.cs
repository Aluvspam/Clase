using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    public abstract class AbstractHandler
    {
        //AbstractHandler super;
        public AbstractHandler nextHandler;
        protected string handlerCode;
        public virtual int Handle(Message message)
        {
            if (nextHandler != null)
            {
                return nextHandler.Handle(message);
            }
            else
            {
                return -2;
            }
        }
        public virtual bool CanHandle(Message message)
        {
            return message.language == handlerCode;
        }
    }

    public class RomanHandler : AbstractHandler
    {
        Dictionary<string, int> dictionar;
        public RomanHandler()
        {
            handlerCode = "Roman";
            dictionar = new Dictionary<string, int>() { { "i", 1 }, { "ii", 2 }, { "iii", 3 }, { "iv", 4 }, { "v", 5 }, { "vi", 6 }, { "vii", 7 }, { "viii", 8 }, { "ix", 9 }, { "x", 10 }, };
        }
        public override int Handle(Message message)
        {
            if (CanHandle(message))
            {
                if (dictionar.ContainsKey(message.Body))
                {
                    return dictionar[message.Body];
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return base.Handle(message);
            }
        }
    }
    public class RoHandler : AbstractHandler
    {
        Dictionary<string, int> dictionar;
        public RoHandler()
        {
            handlerCode = "Ro";
            dictionar = new Dictionary<string, int>() { { "unu", 1 }, { "doi", 2 }, { "trei", 3 }, { "patru", 4 }, { "cinci", 5 }, { "sase", 6 }, { "sapte", 7 }, { "opt", 8 }, { "noua", 9 }, { "zece", 10 }, };
        }
        public override int Handle(Message message)
        {
            if (CanHandle(message))
            {
                if (dictionar.ContainsKey(message.Body))
                {
                    return dictionar[message.Body];
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return base.Handle(message);
            }
        }
    }
}
