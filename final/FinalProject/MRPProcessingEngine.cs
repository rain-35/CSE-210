public class MRPProcessingEngine
{
    public static void CalculateTimePhasedRequirements(
        ManufacturedGood assembly, 
        int batchSize, 
        DateTime assemblyDueDate, 
        Dictionary<string, MaterialRequirement> totalRequirements)
    {
        if (assembly == null || assembly.Recipe == null)
        {
            return;
        }

   
        DateTime assemblyStartDate = assemblyDueDate.AddDays(-assembly.LeadTimeDays);


        foreach (BillOfMaterialItem item in assembly.Recipe)
        {
            Component subPart = item.SubComponent;
            int totalNeeded = item.QuantityRequired * batchSize;


            DateTime subPartDueDate = assemblyStartDate;

            if (subPart is ManufacturedGood subAssembly)
            {

                CalculateTimePhasedRequirements(subAssembly, totalNeeded, subPartDueDate, totalRequirements);
            }
            else 
            {
                if (totalRequirements.ContainsKey(subPart.PartNumber))
                {

                    MaterialRequirement existing = totalRequirements[subPart.PartNumber];
                    existing.AddQuantity(totalNeeded);
                    existing.UpdateToEarlierDate(subPartDueDate);
                }
                else
                {

                    totalRequirements.Add(subPart.PartNumber, new MaterialRequirement(totalNeeded, subPartDueDate));
                }
            }
        }
    }
}