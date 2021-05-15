using System;

namespace OOPExamples
{
    public enum CaseType { Tower, MiniTower }

    class Desktop : Computer
    {
        public CaseType CaseType { get; private set; }
        public override string Name => $"{base.Name} {CaseType}";

        public Desktop(string name, CaseType caseType) : base(name)
        {
            CaseType = caseType;
        }
    }
}