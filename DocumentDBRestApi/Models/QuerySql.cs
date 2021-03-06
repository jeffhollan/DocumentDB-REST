﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class QuerySql
    {
        /// <summary>
        ///     Initializes a new instance of the QuerySql class.
        /// </summary>
        public QuerySql()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the QuerySql class with required
        ///     arguments.
        /// </summary>
        public QuerySql(string query)
            : this()
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }
            Query = query;
        }

        /// <summary>
        ///     Required. The value of this property the SQL statement to be
        ///     executed.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        ///     Serialize the object
        /// </summary>
        /// <returns>
        ///     Returns the json model for the type QuerySql
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (Query == null)
            {
                throw new ArgumentNullException(nameof(Query));
            }
            if (Query != null)
            {
                outputObject["query"] = Query;
            }
            return outputObject;
        }
    }
}