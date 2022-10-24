namespace FourthTask
{
    public class ApplicationLicense
    {
        public string TrialKey { get; set; }
        public string ProKey { get; set; }
        public LicenseLevel Level { get; set; }
        public string Status { get { return $"You are using {Level.ToString()} version"; } }

        public ApplicationLicense()
        {
            TrialKey = 11112222.ToString();
            ProKey = 22224444.ToString();
            Level = LicenseLevel.Free;
        }

        public bool AllowTrial(string key)
        {
            if (key == TrialKey)
            {
                Level = LicenseLevel.Trial;
                return true;
            }

            return false;
        }

        public void AllowCommon()
        {
            Level = LicenseLevel.Free;
        }

        public bool AllowPro(string key)
        {
            if (key == ProKey)
            {
                Level = LicenseLevel.Pro;
                return true;
            }

            return false;
        }

    }
}
