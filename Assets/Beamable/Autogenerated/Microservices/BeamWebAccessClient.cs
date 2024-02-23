//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beamable.Server.Clients
{
    using System;
    using Beamable.Platform.SDK;
    using Beamable.Server;
    
    
    /// <summary> A generated client for <see cref="Beamable.Microservices.BeamWebAccess"/> </summary
    public sealed class BeamWebAccessClient : MicroserviceClient, Beamable.Common.IHaveServiceName
    {
        
        public BeamWebAccessClient(BeamContext context = null) : 
                base(context)
        {
        }
        
        public string ServiceName
        {
            get
            {
                return "BeamWebAccess";
            }
        }
        
        /// <summary>
        /// Call the RollDice method on the BeamWebAccess microservice
        /// <see cref="Beamable.Microservices.BeamWebAccess.RollDice"/>
        /// </summary>
        public Beamable.Common.Promise<Beamable.Common.Unit> RollDice()
        {
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            return this.Request<Beamable.Common.Unit>("BeamWebAccess", "RollDice", serializedFields);
        }
        
        /// <summary>
        /// Call the CheckDiceRolled method on the BeamWebAccess microservice
        /// <see cref="Beamable.Microservices.BeamWebAccess.CheckDiceRolled"/>
        /// </summary>
        public Beamable.Common.Promise<string> CheckDiceRolled()
        {
            System.Collections.Generic.Dictionary<string, object> serializedFields = new System.Collections.Generic.Dictionary<string, object>();
            return this.Request<string>("BeamWebAccess", "CheckDiceRolled", serializedFields);
        }
    }
    
    internal sealed class MicroserviceParametersBeamWebAccessClient
    {
    }
    
    [BeamContextSystemAttribute()]
    public static class ExtensionsForBeamWebAccessClient
    {
        
        [Beamable.Common.Dependencies.RegisterBeamableDependenciesAttribute()]
        public static void RegisterService(Beamable.Common.Dependencies.IDependencyBuilder builder)
        {
            builder.AddScoped<BeamWebAccessClient>();
        }
        
        public static BeamWebAccessClient BeamWebAccess(this Beamable.Server.MicroserviceClients clients)
        {
            return clients.GetClient<BeamWebAccessClient>();
        }
    }
}