namespace tabela_capacitor.Classes
{
	public static class ReturnStringForFile
	{
		public static string StringForFile(string queryName)
		{
			try
			{
				var textQuery = string.Empty;
				var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.FullName.Contains("tabela_capacitor"));
				var name = assembly.GetManifestResourceNames().FirstOrDefault(x => x.EndsWith(queryName));
				//var names = assembly.GetManifestResourceNames();

				using var stream = assembly.GetManifestResourceStream(name);
				using var reader = new StreamReader(stream);
				textQuery = reader.ReadToEnd();

				return textQuery;
			}
			catch (Exception)
			{
				throw new Exception($"Não foi possível carregar o arquivo: {queryName}");
			}
		}
	}
}
