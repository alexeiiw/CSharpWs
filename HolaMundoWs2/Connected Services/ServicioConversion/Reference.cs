﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HolaMundoWs2.ServicioConversion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.webserviceX.NET/", ConfigurationName="ServicioConversion.ConvertWeightsSoap")]
    public interface ConvertWeightsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/ConvertWeight", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        double ConvertWeight(double Weight, HolaMundoWs2.ServicioConversion.WeightUnit FromUnit, HolaMundoWs2.ServicioConversion.WeightUnit ToUnit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/ConvertWeight", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertWeightAsync(double Weight, HolaMundoWs2.ServicioConversion.WeightUnit FromUnit, HolaMundoWs2.ServicioConversion.WeightUnit ToUnit);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.webserviceX.NET/")]
    public enum WeightUnit {
        
        /// <comentarios/>
        Grains,
        
        /// <comentarios/>
        Scruples,
        
        /// <comentarios/>
        Carats,
        
        /// <comentarios/>
        Grams,
        
        /// <comentarios/>
        Pennyweight,
        
        /// <comentarios/>
        DramAvoir,
        
        /// <comentarios/>
        DramApoth,
        
        /// <comentarios/>
        OuncesAvoir,
        
        /// <comentarios/>
        OuncesTroyApoth,
        
        /// <comentarios/>
        Poundals,
        
        /// <comentarios/>
        PoundsTroy,
        
        /// <comentarios/>
        PoundsAvoir,
        
        /// <comentarios/>
        Kilograms,
        
        /// <comentarios/>
        Stones,
        
        /// <comentarios/>
        QuarterUS,
        
        /// <comentarios/>
        Slugs,
        
        /// <comentarios/>
        weight100UScwt,
        
        /// <comentarios/>
        ShortTons,
        
        /// <comentarios/>
        MetricTonsTonne,
        
        /// <comentarios/>
        LongTons,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConvertWeightsSoapChannel : HolaMundoWs2.ServicioConversion.ConvertWeightsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConvertWeightsSoapClient : System.ServiceModel.ClientBase<HolaMundoWs2.ServicioConversion.ConvertWeightsSoap>, HolaMundoWs2.ServicioConversion.ConvertWeightsSoap {
        
        public ConvertWeightsSoapClient() {
        }
        
        public ConvertWeightsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConvertWeightsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertWeightsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertWeightsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ConvertWeight(double Weight, HolaMundoWs2.ServicioConversion.WeightUnit FromUnit, HolaMundoWs2.ServicioConversion.WeightUnit ToUnit) {
            return base.Channel.ConvertWeight(Weight, FromUnit, ToUnit);
        }
        
        public System.Threading.Tasks.Task<double> ConvertWeightAsync(double Weight, HolaMundoWs2.ServicioConversion.WeightUnit FromUnit, HolaMundoWs2.ServicioConversion.WeightUnit ToUnit) {
            return base.Channel.ConvertWeightAsync(Weight, FromUnit, ToUnit);
        }
    }
}