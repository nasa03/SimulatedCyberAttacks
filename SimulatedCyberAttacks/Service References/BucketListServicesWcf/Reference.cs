﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimulatedCyberAttacks.BucketListServicesWcf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BucketListServicesWcf.IBucketListServices")]
    public interface IBucketListServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/ProcessUser", ReplyAction="http://tempuri.org/IBucketListServices/ProcessUserResponse")]
        string ProcessUser(string encodedUser, string encodedPass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/ProcessUser", ReplyAction="http://tempuri.org/IBucketListServices/ProcessUserResponse")]
        System.Threading.Tasks.Task<string> ProcessUserAsync(string encodedUser, string encodedPass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/ProcessUserRegistration", ReplyAction="http://tempuri.org/IBucketListServices/ProcessUserRegistrationResponse")]
        bool ProcessUserRegistration(string encodedUser, string encodedEmail, string encodedPass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/ProcessUserRegistration", ReplyAction="http://tempuri.org/IBucketListServices/ProcessUserRegistrationResponse")]
        System.Threading.Tasks.Task<bool> ProcessUserRegistrationAsync(string encodedUser, string encodedEmail, string encodedPass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/GetBucketListItems", ReplyAction="http://tempuri.org/IBucketListServices/GetBucketListItemsResponse")]
        string[] GetBucketListItems(string encodedUserName, string encodedSortString, string encodedToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/GetBucketListItems", ReplyAction="http://tempuri.org/IBucketListServices/GetBucketListItemsResponse")]
        System.Threading.Tasks.Task<string[]> GetBucketListItemsAsync(string encodedUserName, string encodedSortString, string encodedToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/UpsertBucketListItem", ReplyAction="http://tempuri.org/IBucketListServices/UpsertBucketListItemResponse")]
        string[] UpsertBucketListItem(string encodedBucketListItems, string encodedUser, string encodedToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/UpsertBucketListItem", ReplyAction="http://tempuri.org/IBucketListServices/UpsertBucketListItemResponse")]
        System.Threading.Tasks.Task<string[]> UpsertBucketListItemAsync(string encodedBucketListItems, string encodedUser, string encodedToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/DeleteBucketListItem", ReplyAction="http://tempuri.org/IBucketListServices/DeleteBucketListItemResponse")]
        string[] DeleteBucketListItem(int bucketListDbId, string encodedUser, string encodedToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBucketListServices/DeleteBucketListItem", ReplyAction="http://tempuri.org/IBucketListServices/DeleteBucketListItemResponse")]
        System.Threading.Tasks.Task<string[]> DeleteBucketListItemAsync(int bucketListDbId, string encodedUser, string encodedToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBucketListServicesChannel : SimulatedCyberAttacks.BucketListServicesWcf.IBucketListServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BucketListServicesClient : System.ServiceModel.ClientBase<SimulatedCyberAttacks.BucketListServicesWcf.IBucketListServices>, SimulatedCyberAttacks.BucketListServicesWcf.IBucketListServices {
        
        public BucketListServicesClient() {
        }
        
        public BucketListServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BucketListServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BucketListServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BucketListServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ProcessUser(string encodedUser, string encodedPass) {
            return base.Channel.ProcessUser(encodedUser, encodedPass);
        }
        
        public System.Threading.Tasks.Task<string> ProcessUserAsync(string encodedUser, string encodedPass) {
            return base.Channel.ProcessUserAsync(encodedUser, encodedPass);
        }
        
        public bool ProcessUserRegistration(string encodedUser, string encodedEmail, string encodedPass) {
            return base.Channel.ProcessUserRegistration(encodedUser, encodedEmail, encodedPass);
        }
        
        public System.Threading.Tasks.Task<bool> ProcessUserRegistrationAsync(string encodedUser, string encodedEmail, string encodedPass) {
            return base.Channel.ProcessUserRegistrationAsync(encodedUser, encodedEmail, encodedPass);
        }
        
        public string[] GetBucketListItems(string encodedUserName, string encodedSortString, string encodedToken) {
            return base.Channel.GetBucketListItems(encodedUserName, encodedSortString, encodedToken);
        }
        
        public System.Threading.Tasks.Task<string[]> GetBucketListItemsAsync(string encodedUserName, string encodedSortString, string encodedToken) {
            return base.Channel.GetBucketListItemsAsync(encodedUserName, encodedSortString, encodedToken);
        }
        
        public string[] UpsertBucketListItem(string encodedBucketListItems, string encodedUser, string encodedToken) {
            return base.Channel.UpsertBucketListItem(encodedBucketListItems, encodedUser, encodedToken);
        }
        
        public System.Threading.Tasks.Task<string[]> UpsertBucketListItemAsync(string encodedBucketListItems, string encodedUser, string encodedToken) {
            return base.Channel.UpsertBucketListItemAsync(encodedBucketListItems, encodedUser, encodedToken);
        }
        
        public string[] DeleteBucketListItem(int bucketListDbId, string encodedUser, string encodedToken) {
            return base.Channel.DeleteBucketListItem(bucketListDbId, encodedUser, encodedToken);
        }
        
        public System.Threading.Tasks.Task<string[]> DeleteBucketListItemAsync(int bucketListDbId, string encodedUser, string encodedToken) {
            return base.Channel.DeleteBucketListItemAsync(bucketListDbId, encodedUser, encodedToken);
        }
    }
}
