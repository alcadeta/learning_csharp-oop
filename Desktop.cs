namespace OOPExamples
{
    public enum CaseType { Tower, MiniTower }

    class Desktop : Computer
    {
        public CaseType CaseType { get; private set; }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            CaseType = caseType;
        }
    }
}