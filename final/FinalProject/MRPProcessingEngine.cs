public class MRPProcessingEngine
{
    public static void CalculateTotalRequirements(ManufacturedGood assembly, int batchSize, Dictionary<string, int> totalRequirements)
    {
        if (assembly == null || assembly.Recipe == null)
        {
            return;
        }

        foreach (BillOfMaterialItem item in assembly.Recipe)
        {
            Component subPart = item.SubComponent;

            int totalNeeded = item.QuantityRequired * batchSize;

            if (subPart is ManufacturedGood subAssembly)
            {
                CalculateTotalRequirements(subAssembly, totalNeeded, totalRequirements);
            }
            else 
            {
                if (totalRequirements.ContainsKey(subPart.PartNumber))
                {
                    totalRequirements[subPart.PartNumber] += totalNeeded;
                }
                else
                {
                    totalRequirements.Add(subPart.PartNumber, totalNeeded);
                }
            }
        }
    }
}