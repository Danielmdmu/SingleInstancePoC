using DynamicData;
using System;

namespace ExplorationSingleInstance
{
    public class ArgumentHandler
    {
        private readonly SourceList<string> _arguments = new SourceList<string>();

        public ArgumentHandler()
        {
            _arguments.Add("init");
        }

        public void Add(string arg)
        {
            _arguments.Add(arg);
        }

        public IObservable<IChangeSet<string>> Connect() => _arguments.Connect();
    }
}