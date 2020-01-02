namespace TopicosEspeciais.Model.Entities_Her_Multipla
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
