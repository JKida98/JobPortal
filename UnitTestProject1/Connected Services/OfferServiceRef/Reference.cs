//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1.OfferServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OfferServiceRef.IOfferService")]
    public interface IOfferService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/CreateServiceOffer", ReplyAction="http://tempuri.org/IOfferService/CreateServiceOfferResponse")]
        bool CreateServiceOffer(JobPortal.Model.Offer offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/CreateServiceOffer", ReplyAction="http://tempuri.org/IOfferService/CreateServiceOfferResponse")]
        System.Threading.Tasks.Task<bool> CreateServiceOfferAsync(JobPortal.Model.Offer offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/FindServiceOffer", ReplyAction="http://tempuri.org/IOfferService/FindServiceOfferResponse")]
        JobPortal.Model.Offer FindServiceOffer(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/FindServiceOffer", ReplyAction="http://tempuri.org/IOfferService/FindServiceOfferResponse")]
        System.Threading.Tasks.Task<JobPortal.Model.Offer> FindServiceOfferAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/DeleteServiceOffer", ReplyAction="http://tempuri.org/IOfferService/DeleteServiceOfferResponse")]
        bool DeleteServiceOffer(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/DeleteServiceOffer", ReplyAction="http://tempuri.org/IOfferService/DeleteServiceOfferResponse")]
        System.Threading.Tasks.Task<bool> DeleteServiceOfferAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/UpdateServiceOffer", ReplyAction="http://tempuri.org/IOfferService/UpdateServiceOfferResponse")]
        bool UpdateServiceOffer(JobPortal.Model.Offer serviceOffer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/UpdateServiceOffer", ReplyAction="http://tempuri.org/IOfferService/UpdateServiceOfferResponse")]
        System.Threading.Tasks.Task<bool> UpdateServiceOfferAsync(JobPortal.Model.Offer serviceOffer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/GetAllOffers", ReplyAction="http://tempuri.org/IOfferService/GetAllOffersResponse")]
        JobPortal.Model.Offer[] GetAllOffers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOfferService/GetAllOffers", ReplyAction="http://tempuri.org/IOfferService/GetAllOffersResponse")]
        System.Threading.Tasks.Task<JobPortal.Model.Offer[]> GetAllOffersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOfferServiceChannel : UnitTestProject1.OfferServiceRef.IOfferService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OfferServiceClient : System.ServiceModel.ClientBase<UnitTestProject1.OfferServiceRef.IOfferService>, UnitTestProject1.OfferServiceRef.IOfferService {
        
        public OfferServiceClient() {
        }
        
        public OfferServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OfferServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OfferServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OfferServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateServiceOffer(JobPortal.Model.Offer offer) {
            return base.Channel.CreateServiceOffer(offer);
        }
        
        public System.Threading.Tasks.Task<bool> CreateServiceOfferAsync(JobPortal.Model.Offer offer) {
            return base.Channel.CreateServiceOfferAsync(offer);
        }
        
        public JobPortal.Model.Offer FindServiceOffer(int ID) {
            return base.Channel.FindServiceOffer(ID);
        }
        
        public System.Threading.Tasks.Task<JobPortal.Model.Offer> FindServiceOfferAsync(int ID) {
            return base.Channel.FindServiceOfferAsync(ID);
        }
        
        public bool DeleteServiceOffer(int ID) {
            return base.Channel.DeleteServiceOffer(ID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteServiceOfferAsync(int ID) {
            return base.Channel.DeleteServiceOfferAsync(ID);
        }
        
        public bool UpdateServiceOffer(JobPortal.Model.Offer serviceOffer) {
            return base.Channel.UpdateServiceOffer(serviceOffer);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateServiceOfferAsync(JobPortal.Model.Offer serviceOffer) {
            return base.Channel.UpdateServiceOfferAsync(serviceOffer);
        }
        
        public JobPortal.Model.Offer[] GetAllOffers() {
            return base.Channel.GetAllOffers();
        }
        
        public System.Threading.Tasks.Task<JobPortal.Model.Offer[]> GetAllOffersAsync() {
            return base.Channel.GetAllOffersAsync();
        }
    }
}
