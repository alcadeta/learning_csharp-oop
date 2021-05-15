using System;

namespace OOPExamples
{
    public enum CaseType { Tower, MiniTower }

    class Desktop : Computer, ISleep
    {
        public CaseType CaseType { get; private set; }

        public bool IsSleeping { get; private set; }
        public override string Name => $"{base.Name} {CaseType}";

        public Desktop(string name, CaseType caseType) : base(name)
        {
            CaseType = caseType;
        }

        public void ToggleSleep()
        {
            if (!IsOn) { return; }
            IsSleeping = !IsSleeping;
        }

        public override void TogglePower()
        {
            if (IsSleeping) { return; }
            base.TogglePower();
        }
    }
}