﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachmentResponse
    {
        /// <summary>
        ///     Initializes a new instance of the AttachmentResponse class.
        /// </summary>
        public AttachmentResponse()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the AttachmentResponse class with
        ///     required arguments.
        /// </summary>
        public AttachmentResponse(string id, string contentType, string media)
            : this()
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            if (media == null)
            {
                throw new ArgumentNullException(nameof(media));
            }
            Id = id;
            ContentType = contentType;
            Media = media;
        }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Rid { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Self { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Ts { get; set; }

        /// <summary>
        ///     Required. This is a user settable property. It specifies the
        ///     content type of th  attachment.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        ///     Required. This is a user settable property. It is the unique name
        ///     that identifies the attachment, i.e. no two attachments share the
        ///     same id. The id must not exceed 255 characters. The value set in
        ///     Slug is recorded here
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Required. This is the URL link or file path where the attachment
        ///     resides.
        /// </summary>
        public string Media { get; set; }

        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var etagValue = inputObject["_etag"];
                if (etagValue != null && etagValue.Type != JTokenType.Null)
                {
                    Etag = (string) etagValue;
                }
                var ridValue = inputObject["_rid"];
                if (ridValue != null && ridValue.Type != JTokenType.Null)
                {
                    Rid = (string) ridValue;
                }
                var selfValue = inputObject["_self"];
                if (selfValue != null && selfValue.Type != JTokenType.Null)
                {
                    Self = (string) selfValue;
                }
                var tsValue = inputObject["_ts"];
                if (tsValue != null && tsValue.Type != JTokenType.Null)
                {
                    Ts = (string) tsValue;
                }
                var contentTypeValue = inputObject["contentType"];
                if (contentTypeValue != null && contentTypeValue.Type != JTokenType.Null)
                {
                    ContentType = (string) contentTypeValue;
                }
                var idValue = inputObject["id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    Id = (string) idValue;
                }
                var mediaValue = inputObject["Media"];
                if (mediaValue != null && mediaValue.Type != JTokenType.Null)
                {
                    Media = (string) mediaValue;
                }
            }
        }
    }
}