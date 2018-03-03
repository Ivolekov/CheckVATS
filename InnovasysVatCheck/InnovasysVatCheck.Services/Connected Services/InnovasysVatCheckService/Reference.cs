﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InnovasysVatCheck.Services.InnovasysVatCheckService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="matchCode", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public enum matchCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="1")]
        _1 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="2")]
        _2 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="3")]
        _3 = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat", ConfigurationName="InnovasysVatCheckService.checkVatPortType")]
    public interface checkVatPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponse checkVat(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponse> checkVatAsync(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponse checkVatApprox(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponse> checkVatApproxAsync(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVat", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequestBody Body;
        
        public checkVatRequest() {
        }
        
        public checkVatRequest(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        public checkVatRequestBody() {
        }
        
        public checkVatRequestBody(string countryCode, string vatNumber) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVatResponse", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponseBody Body;
        
        public checkVatResponse() {
        }
        
        public checkVatResponse(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string requestDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool valid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string address;
        
        public checkVatResponseBody() {
        }
        
        public checkVatResponseBody(string countryCode, string vatNumber, string requestDate, bool valid, string name, string address) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.requestDate = requestDate;
            this.valid = valid;
            this.name = name;
            this.address = address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatApproxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVatApprox", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequestBody Body;
        
        public checkVatApproxRequest() {
        }
        
        public checkVatApproxRequest(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatApproxRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string traderName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string traderCompanyType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string traderStreet;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string traderPostcode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string traderCity;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string requesterCountryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string requesterVatNumber;
        
        public checkVatApproxRequestBody() {
        }
        
        public checkVatApproxRequestBody(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.traderName = traderName;
            this.traderCompanyType = traderCompanyType;
            this.traderStreet = traderStreet;
            this.traderPostcode = traderPostcode;
            this.traderCity = traderCity;
            this.requesterCountryCode = requesterCountryCode;
            this.requesterVatNumber = requesterVatNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatApproxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVatApproxResponse", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponseBody Body;
        
        public checkVatApproxResponse() {
        }
        
        public checkVatApproxResponse(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatApproxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string requestDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool valid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string traderName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string traderCompanyType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string traderAddress;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string traderStreet;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string traderPostcode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string traderCity;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderNameMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderCompanyTypeMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderStreetMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=13)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderPostcodeMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=14)]
        public InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderCityMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string requestIdentifier;
        
        public checkVatApproxResponseBody() {
        }
        
        public checkVatApproxResponseBody(
                    string countryCode, 
                    string vatNumber, 
                    string requestDate, 
                    bool valid, 
                    string traderName, 
                    string traderCompanyType, 
                    string traderAddress, 
                    string traderStreet, 
                    string traderPostcode, 
                    string traderCity, 
                    InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderNameMatch, 
                    InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderCompanyTypeMatch, 
                    InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderStreetMatch, 
                    InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderPostcodeMatch, 
                    InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderCityMatch, 
                    string requestIdentifier) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.requestDate = requestDate;
            this.valid = valid;
            this.traderName = traderName;
            this.traderCompanyType = traderCompanyType;
            this.traderAddress = traderAddress;
            this.traderStreet = traderStreet;
            this.traderPostcode = traderPostcode;
            this.traderCity = traderCity;
            this.traderNameMatch = traderNameMatch;
            this.traderCompanyTypeMatch = traderCompanyTypeMatch;
            this.traderStreetMatch = traderStreetMatch;
            this.traderPostcodeMatch = traderPostcodeMatch;
            this.traderCityMatch = traderCityMatch;
            this.requestIdentifier = requestIdentifier;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface checkVatPortTypeChannel : InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class checkVatPortTypeClient : System.ServiceModel.ClientBase<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType>, InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType {
        
        public checkVatPortTypeClient() {
        }
        
        public checkVatPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public checkVatPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public checkVatPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public checkVatPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponse InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType.checkVat(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest request) {
            return base.Channel.checkVat(request);
        }
        
        public string checkVat(ref string countryCode, ref string vatNumber, out bool valid, out string name, out string address) {
            InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest inValue = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest();
            inValue.Body = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequestBody();
            inValue.Body.countryCode = countryCode;
            inValue.Body.vatNumber = vatNumber;
            InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponse retVal = ((InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType)(this)).checkVat(inValue);
            countryCode = retVal.Body.countryCode;
            vatNumber = retVal.Body.vatNumber;
            valid = retVal.Body.valid;
            name = retVal.Body.name;
            address = retVal.Body.address;
            return retVal.Body.requestDate;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponse> InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType.checkVatAsync(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest request) {
            return base.Channel.checkVatAsync(request);
        }
        
        public System.Threading.Tasks.Task<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatResponse> checkVatAsync(string countryCode, string vatNumber) {
            InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest inValue = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequest();
            inValue.Body = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatRequestBody();
            inValue.Body.countryCode = countryCode;
            inValue.Body.vatNumber = vatNumber;
            return ((InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType)(this)).checkVatAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponse InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType.checkVatApprox(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest request) {
            return base.Channel.checkVatApprox(request);
        }
        
        public string checkVatApprox(
                    ref string countryCode, 
                    ref string vatNumber, 
                    ref string traderName, 
                    ref string traderCompanyType, 
                    ref string traderStreet, 
                    ref string traderPostcode, 
                    ref string traderCity, 
                    string requesterCountryCode, 
                    string requesterVatNumber, 
                    out bool valid, 
                    out string traderAddress, 
                    out InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderNameMatch, 
                    out InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderCompanyTypeMatch, 
                    out InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderStreetMatch, 
                    out InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderPostcodeMatch, 
                    out InnovasysVatCheck.Services.InnovasysVatCheckService.matchCode traderCityMatch, 
                    out string requestIdentifier) {
            InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest inValue = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest();
            inValue.Body = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequestBody();
            inValue.Body.countryCode = countryCode;
            inValue.Body.vatNumber = vatNumber;
            inValue.Body.traderName = traderName;
            inValue.Body.traderCompanyType = traderCompanyType;
            inValue.Body.traderStreet = traderStreet;
            inValue.Body.traderPostcode = traderPostcode;
            inValue.Body.traderCity = traderCity;
            inValue.Body.requesterCountryCode = requesterCountryCode;
            inValue.Body.requesterVatNumber = requesterVatNumber;
            InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponse retVal = ((InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType)(this)).checkVatApprox(inValue);
            countryCode = retVal.Body.countryCode;
            vatNumber = retVal.Body.vatNumber;
            valid = retVal.Body.valid;
            traderName = retVal.Body.traderName;
            traderCompanyType = retVal.Body.traderCompanyType;
            traderAddress = retVal.Body.traderAddress;
            traderStreet = retVal.Body.traderStreet;
            traderPostcode = retVal.Body.traderPostcode;
            traderCity = retVal.Body.traderCity;
            traderNameMatch = retVal.Body.traderNameMatch;
            traderCompanyTypeMatch = retVal.Body.traderCompanyTypeMatch;
            traderStreetMatch = retVal.Body.traderStreetMatch;
            traderPostcodeMatch = retVal.Body.traderPostcodeMatch;
            traderCityMatch = retVal.Body.traderCityMatch;
            requestIdentifier = retVal.Body.requestIdentifier;
            return retVal.Body.requestDate;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponse> InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType.checkVatApproxAsync(InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest request) {
            return base.Channel.checkVatApproxAsync(request);
        }
        
        public System.Threading.Tasks.Task<InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxResponse> checkVatApproxAsync(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber) {
            InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest inValue = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequest();
            inValue.Body = new InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatApproxRequestBody();
            inValue.Body.countryCode = countryCode;
            inValue.Body.vatNumber = vatNumber;
            inValue.Body.traderName = traderName;
            inValue.Body.traderCompanyType = traderCompanyType;
            inValue.Body.traderStreet = traderStreet;
            inValue.Body.traderPostcode = traderPostcode;
            inValue.Body.traderCity = traderCity;
            inValue.Body.requesterCountryCode = requesterCountryCode;
            inValue.Body.requesterVatNumber = requesterVatNumber;
            return ((InnovasysVatCheck.Services.InnovasysVatCheckService.checkVatPortType)(this)).checkVatApproxAsync(inValue);
        }
    }
}
