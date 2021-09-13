using System;

namespace Adapter
{
    public class RichCompound : Compound
    {
        private readonly string _chemical;
        private ChemicalDataBank _chemicalDataBank;

        public RichCompound(string chemical)
        {
            _chemical = chemical;
        }

        public override void Display()
        {
            _chemicalDataBank = new ChemicalDataBank();
            molecularFormula = _chemicalDataBank.GetMolecularStructure(_chemical);
            molecularWeight = _chemicalDataBank.GetMolecularWeight(_chemical);

            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight : {0}", molecularWeight);
        }
    }
}