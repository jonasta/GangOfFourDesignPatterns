namespace Adapter
{
    public class ChemicalDataBank
    {
        // this simulates a 'legacy API'
        public string GetMolecularStructure(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => "H2O",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => "",
            };
        }

        public double GetMolecularWeight(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => 18.015,
                "benzene" => 78.1134,
                "ethanol" => 46.0688,
                _ => 0d,
            };
        }
    }
}