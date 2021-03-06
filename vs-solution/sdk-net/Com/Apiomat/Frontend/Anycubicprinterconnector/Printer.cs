/*
 * Copyright (c) 2011 - 2017, Apinauten GmbH
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 *
 *  * Redistributions of source code must retain the above copyright notice, this 
 *    list of conditions and the following disclaimer.
 *  * Redistributions in binary form must reproduce the above copyright notice, 
 *    this list of conditions and the following disclaimer in the documentation 
 *    and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE 
 * OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED 
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * THIS FILE IS GENERATED AUTOMATICALLY. DON'T MODIFY IT.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Com.Apiomat.Frontend.Basics;
using Com.Apiomat.Frontend.Extensions;
using Com.Apiomat.Frontend.Helper;

									

namespace Com.Apiomat.Frontend.AnycubicPrinterConnector
{
    /// <summary>
    /// Generated class for Printer 
    /// </summary>
    public class Printer : AbstractClientDataModel
    {
        private Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData currentJob = null;
        private IList<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData> toolHistory = new List<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData>();
        /// <summary>
        /// Default constructor. Needed for internal processing.
        /// </summary>
        public Printer ( ) : base()
        {
        }
    

        /// <summary>
        /// Returns the simple name of this class 
        /// </summary>
        public override string SimpleName { get { return "Printer"; } }

        /// <summary>
        /// Returns the name of the module where this class belongs to
        /// </summary>
        public override string ModuleName { get { return "AnycubicPrinterConnector"; } }

        /// <summary>
        /// Returns a list of objects of this class filtered by the given query from server.
        /// The size of the resultset is limited to an installation specific value ('maxResults') and defaults to 1000. 
        /// Use limit and offset to return all results if the expected size is larger.
        /// </summary>
        /// <param name="query">A query filtering the results in SQL style (see http://www.apiomat.com/docs/concepts/query-language/)</param>
        /// <returns>A list of objects of this class filtered by the given query from server</returns>
        /// <exception cref="Exception">When something fails</exception>
        public static async Task<IList<Printer>> GetPrintersAsync(string query = null) 
        {
            Printer o = new  Printer();
            return await Datastore.Instance.LoadFromServerAsync<Printer>(o.ModuleName, o.SimpleName, query, false, false, Datastore.Instance.GetOfflineUsageForType(typeof(Printer))).ConfigureAwait(false);
        }
        
        /// <summary>
        /// Returns a list of objects of this class filtered by the given query from server.
        /// The size of the resultset is limited to an installation specific value ('maxResults') and defaults to 1000. 
        /// Use limit and offset to return all results if the expected size is larger.
        /// </summary>
        /// <param name="query">A query filtering the results in SQL style (see http://www.apiomat.com/docs/concepts/query-language/)</param>
        /// <param name="withReferencedHrefs">Set <c>true</c> to also get all HREFs of referenced class instances</param>
        /// <returns>A list of objects of this class filtered by the given query from server</returns>
        /// <exception cref="Exception">When something fails</exception>
        public static async Task<IList<Printer>> GetPrintersAsync(string query, bool withReferencedHrefs) 
        {
            Printer o = new  Printer();
            return await Datastore.Instance.LoadFromServerAsync<Printer>(o.ModuleName, o.SimpleName, query, withReferencedHrefs, false, Datastore.Instance.GetOfflineUsageForType(typeof(Printer))).ConfigureAwait(false);
        }
    
        /// <summary>
        /// Returns a list of objects of this class filtered by the given query from server.
        /// The size of the resultset is limited to an installation specific value ('maxResults') and defaults to 1000. 
        /// Use limit and offset to return all results if the expected size is larger.
        /// </summary>
        /// <param name="query">A query filtering the results in SQL style (see http://www.apiomat.com/docs/concepts/query-language/)</param>
        /// <param name="withReferencedHrefs">Set <c>true</c> to also get all HREFs of referenced class instances</param>
        /// <param name="usePersistentStorage">Set <c>true</c> to store the object in persistent storage </param>
        /// <returns>A list of objects of this class filtered by the given query from server</returns>
        /// <exception cref="Exception">When something fails</exception>
        public static async Task<IList<Printer>> GetPrintersAsync(string query, bool withReferencedHrefs, bool usePersistentStorage) 
        {
            Printer o = new  Printer();
            return await Datastore.Instance.LoadFromServerAsync<Printer>(o.ModuleName, o.SimpleName, query, withReferencedHrefs, false, usePersistentStorage).ConfigureAwait(false);
        }
        
        /// <summary>
        /// Returns the count of objects of this class filtered by the given query from the server.
        /// </summary>
        /// <param name="query">A query filtering the results in SQL style (see http://www.apiomat.com/docs/concepts/query-language/)</param>
        /// <returns>The (filtered) count of objects of this class</returns>
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public static async Task<long> GetPrintersCountAsync( string query = null )
        {
            Printer o = new Printer();
            string countHref = Datastore.Instance.CreateModelHref( o.ModuleName, o.SimpleName ) + "/count";
            return await Datastore.Instance.CountFromServerAsync(countHref, query, false, false).ConfigureAwait(false);
        }


            public string Address
        {
            get
            {
                return Data.GetOrDefault<string>("address");
            }

            set
            {
                Data["address"] = JToken.Parse(JsonConvert.SerializeObject(value));
            }
        }

    
        /// <summary>
        /// Getter for local variable containing the referenced object
        /// </summary>
        public Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData CurrentJob { get { return currentJob; } }

        /// <summary>
        /// Loads the referenced object, adds the result from the server to the local member variable of this object and also returns a Task containing the result
        /// </summary>
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task<Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData> LoadCurrentJobAsync( )
        {
            return await LoadCurrentJobAsync<Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData>(Datastore.Instance.GetOfflineUsageForType(typeof(Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData))).ConfigureAwait(false);
        }
    
        public async Task< T > LoadCurrentJobAsync<T>(  ) where T : Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData
        {
            return await LoadCurrentJobAsync<T>(Datastore.Instance.GetOfflineUsageForType(typeof(T))).ConfigureAwait(false);
        }
        /// <summary>
        /// Loads the referenced object, adds the result from the server to the local member variable of this object and also returns a Task containing the result.
        /// A precondition is that a referenced object was attached to this object before, so that when loading this object,
        /// there's a known URL of currentJob, or alternatively you attach a referenced object after loading this object.
        /// </summary>
        /// <exception cref="ApiomatRequestException">With status <see cref="Status.ATTACHED_HREF_MISSING"/>
        /// when no reference object was attached to the current object before. Other statuses when the request fails</exception>
        public async Task< T > LoadCurrentJobAsync<T>(bool usePersistentStorage  ) where T : Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData
        {
            string refUrl = Data["currentJobHref"].ToObject<string>();
            if ( string.IsNullOrEmpty(refUrl) )
            {
                throw new ApiomatRequestException(Status.ATTACHED_HREF_MISSING);
            }
            T result = await Datastore.Instance.LoadFromServerAsync<T>(refUrl, false, true, usePersistentStorage).ConfigureAwait(false);
            currentJob = result;
            return result;
        }


        public async Task<string> PostCurrentJobAsync(Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData refData) 
        {
            return await PostCurrentJobAsync(refData, Datastore.Instance.GetOfflineUsageForType(typeof(Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData))).ConfigureAwait(false);
        }
        
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task<string> PostCurrentJobAsync(Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData refData, bool usePersistentStorage) {
            string href = refData.Href;
            if( string.IsNullOrEmpty(href) )
            {
                throw new ApiomatRequestException(Status.SAVE_REFERENECE_BEFORE_REFERENCING);
            }
            string refHref = null;
            /* Let's check if we use offline storage or send req to server */
            if(Datastore.Instance.SendOffline(HttpMethod.Post))
            {
                refHref = Datastore.Instance.OfflineHandler.AddTask(HttpMethod.Post, Href, refData, "currentJob", true, usePersistentStorage );
            } 
            else
            {
                refHref = await Datastore.Instance.PostOnServerAsync(refData, Data.GetOrDefault<string>("currentJobHref", string.Empty, true), true, usePersistentStorage).ConfigureAwait(false);
            }
            currentJob = refData;
            return refHref;
        }
        
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task RemoveCurrentJobAsync( Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData refData ) 
        {
            await RemoveCurrentJobAsync( refData, Datastore.Instance.GetOfflineUsageForType(typeof(Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData))).ConfigureAwait(false);
        }
        
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task RemoveCurrentJobAsync( Com.Apiomat.Frontend.AnycubicPrinterConnector.JobData refData, bool usePersistentStorage )
        {
            string id = refData.Href.Substring( refData.Href.LastIndexOf( "/" ) + 1 );
            if(Datastore.Instance.SendOffline(HttpMethod.Delete))
            {
                Datastore.Instance.OfflineHandler.AddTask(HttpMethod.Delete, Href, refData, "currentJob", true, usePersistentStorage );
            }
            else
            {
                await Datastore.Instance.DeleteOnServerAsync( Data.GetOrDefault<string>("currentJobHref", string.Empty, true) + "/" + id, true, usePersistentStorage ).ConfigureAwait(false);
            }
            currentJob = null;
        }

 

    
        /// <summary>
        /// Getter for local variable containing the referenced object collection
        /// </summary>
        public IList<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData> ToolHistory { get { return toolHistory; } }

        /// <summary>
        /// Loads the referenced objects, adds the result from the server to the local member variable of this object and also returns a Task containing the result
        /// </summary>
        /// <param name="query">Optional query for filtering the returned objects</param>
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task<IList<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData>> LoadToolHistoryAsync(string query = null )
        {
            return await LoadToolHistoryAsync<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData>(Datastore.Instance.GetOfflineUsageForType(typeof(Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData)), query).ConfigureAwait(false);
        }
    
        public async Task<IList<T>> LoadToolHistoryAsync<T>(  string query = null  ) where T : Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData
        {
            return await LoadToolHistoryAsync<T>(Datastore.Instance.GetOfflineUsageForType(typeof(T)), query).ConfigureAwait(false);
        }
        /// <summary>
        /// Loads the referenced objects, adds the result from the server to the local member variable of this object and also returns a Task containing the result.
        /// A precondition is that a referenced object was attached to this object before, so that when loading this object,
        /// there's a known URL of toolHistory, or alternatively you attach a referenced object after loading this object.
        /// </summary>
        /// <param name="query">Optional query for filtering the returned objects</param>
        /// <exception cref="ApiomatRequestException">With status <see cref="Status.ATTACHED_HREF_MISSING"/>
        /// when no reference object was attached to the current object before. Other statuses when the request fails</exception>
        public async Task<IList<T>> LoadToolHistoryAsync<T>(bool usePersistentStorage , string query = null  ) where T : Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData
        {
            string refUrl = Data["toolHistoryHref"].ToObject<string>();
            if ( string.IsNullOrEmpty(refUrl) )
            {
                throw new ApiomatRequestException(Status.ATTACHED_HREF_MISSING);
            }
            IList<T> result = await Datastore.Instance.LoadFromServerAsync<T>(refUrl, query, false, true, false, usePersistentStorage).ConfigureAwait(false);
            toolHistory.Clear();
            ((List<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData>)toolHistory).AddRange(result); // Cast necessary for AddRange() method, because it's not part of the IList interface
            return result;
        }

        /// <summary>
        /// Returns the count of objects of the referenced class filtered by the given query from the server
        /// </summary>
        /// <param name="query">A query filtering the results in SQL style (see http://www.apiomat.com/docs/concepts/query-language/)</param>
        /// <returns>The (filtered) count of objects of the referenced class</returns>
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task<long> GetToolHistoryCountAsync( string query = null )
        {
            string countHref = Href + "/toolHistory/count";
            return await Datastore.Instance.CountFromServerAsync(countHref, query, false, false).ConfigureAwait(false);
        }

        public async Task<string> PostToolHistoryAsync(Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData refData) 
        {
            return await PostToolHistoryAsync(refData, Datastore.Instance.GetOfflineUsageForType(typeof(Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData))).ConfigureAwait(false);
        }
        
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task<string> PostToolHistoryAsync(Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData refData, bool usePersistentStorage) {
            string href = refData.Href;
            if( string.IsNullOrEmpty(href) )
            {
                throw new ApiomatRequestException(Status.SAVE_REFERENECE_BEFORE_REFERENCING);
            }
            string refHref = null;
            /* Let's check if we use offline storage or send req to server */
            if(Datastore.Instance.SendOffline(HttpMethod.Post))
            {
                refHref = Datastore.Instance.OfflineHandler.AddTask(HttpMethod.Post, Href, refData, "toolHistory", true, usePersistentStorage );
            } 
            else
            {
                refHref = await Datastore.Instance.PostOnServerAsync(refData, Data.GetOrDefault<string>("toolHistoryHref", string.Empty, true), true, usePersistentStorage).ConfigureAwait(false);
            }
            // check if local list contains refData with same href
            if( !string.IsNullOrEmpty(refHref) && ModelHelper.ContainsHref<Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData>(toolHistory, refHref)==false)
            {
                toolHistory.Add(refData);
            }
            return refHref;
        }
        
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task RemoveToolHistoryAsync( Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData refData ) 
        {
            await RemoveToolHistoryAsync( refData, Datastore.Instance.GetOfflineUsageForType(typeof(Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData))).ConfigureAwait(false);
        }
        
        /// <exception cref="ApiomatRequestException">When the request fails</exception>
        public async Task RemoveToolHistoryAsync( Com.Apiomat.Frontend.AnycubicPrinterConnector.ToolData refData, bool usePersistentStorage )
        {
            string id = refData.Href.Substring( refData.Href.LastIndexOf( "/" ) + 1 );
            if(Datastore.Instance.SendOffline(HttpMethod.Delete))
            {
                Datastore.Instance.OfflineHandler.AddTask(HttpMethod.Delete, Href, refData, "toolHistory", true, usePersistentStorage );
            }
            else
            {
                await Datastore.Instance.DeleteOnServerAsync( Data.GetOrDefault<string>("toolHistoryHref", string.Empty, true) + "/" + id, true, usePersistentStorage ).ConfigureAwait(false);
            }
            toolHistory.Remove(refData);
        }

        public int DeleteToolHistoryFromStorage( string query )
        {
    		string refUrl = this.Data.GetOrDefault( "toolHistoryHref", string.Empty, true );
    		string ret =  refUrl ;
    		ret +=  "?withReferencedHrefs=false&q=";
    		if (query != null)
    		{
    			ret += query ;
    		}
    		return Datastore.Instance.DeleteCollectionFromStorage( ret );
        }
 



        /// <summary>
        /// Obsolete. Use RemoveFromStorage instead.
        /// </summary>
        [Obsolete]
        public static int DeleteAllFromStorage(string query = null)
        {
        	return RemoveFromStorage( query, false );
        }
        
        /// <summary>
        /// Obsolete. Use RemoveFromStorage instead.
        /// </summary>
        [Obsolete]
        public static int DeleteAllFromStorageWithReferencedHrefs( string query = null )
        {
        	return RemoveFromStorage( query, true ); 
        }
        
        /// <summary>
        /// Removes objects of this class that were loaded into storage before.
        /// 
        /// Note 1: This ONLY removes objects fetched with getPrintersAsync(), which doesn't include loaded referenced objects!
        /// Note 2: The SDK doesn't contain a query parser, so you need to pass the same query as in the fetch request.
        ///  Also, if an object was included in the result of multiple queries, the object doesn't get removed
        /// </summary>
        /// <returns>The number of removed objects</returns>
        /// <param name="query">The query you used when fetching the object collection</param>
        /// <param name="withReferencedHrefs">Use true or false depending on what you used when fetching the object collection</param>
        public static int RemoveFromStorage( string query = null, bool withReferencedHrefs = false )
        {
            Printer o = new Printer();
            string collectionHref = Datastore.Instance.CreateModelHrefWithParams( o.ModuleName,
                o.SimpleName, withReferencedHrefs, query );
            return Datastore.Instance.DeleteCollectionFromStorage( collectionHref );
        }
        
        /// <summary>
        /// Removes ALL objects of this class that were loaded into storage before, independent of any queries.
        /// </summary>
        /// <returns>The number of removed objects</returns>
        public static int RemoveAllFromStorage( )
        {
            Printer o = new Printer();
            return Datastore.Instance.RemoveAllFromStorage( o.ModuleName, o.SimpleName );
        }
        
    }
}
