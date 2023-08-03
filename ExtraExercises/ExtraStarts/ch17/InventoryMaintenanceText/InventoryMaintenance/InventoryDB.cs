namespace InventoryMaintenance
{
	public static class InventoryDB
	{
		private const string Path = @"C:\Users\Maya\Documents\GitHub\AWD1100-Summer2023-mayaRanken\ExtraExercises\ExtraStarts\ch17\InventoryMaintenanceText\InventoryMaintenance\InventoryItems.txt";

        public static List<InventoryItem> GetItems()
		{
            // create the list
            List<InventoryItem> items = new();

            // Add code here to read the text file into the List<InventoryItem> object.
            FileStream fileStream = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);


            return items;
		}

		public static void SaveItems(List<InventoryItem> items)
		{
            // Add code here to write the List<InventoryItems> object to a text file.
        }
    }
}