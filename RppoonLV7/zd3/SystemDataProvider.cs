namespace zd3
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad != this.previousCPULoad)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentAvailableRam = this.AvailableRAM;
            if (currentAvailableRam != this.AvailableRAM)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentAvailableRam;
            return currentAvailableRam;
        }
    }

}
