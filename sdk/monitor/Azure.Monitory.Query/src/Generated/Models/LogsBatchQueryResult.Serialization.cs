// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitory.Query.Models
{
    public partial class LogsBatchQueryResult
    {
        internal static LogsBatchQueryResult DeserializeLogsBatchQueryResult(JsonElement element)
        {
            Optional<IReadOnlyList<LogQueryResponse>> responses = default;
            Optional<BatchResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("responses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LogQueryResponse> array = new List<LogQueryResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogQueryResponse.DeserializeLogQueryResponse(item));
                    }
                    responses = array;
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = BatchResponseError.DeserializeBatchResponseError(property.Value);
                    continue;
                }
            }
            return new LogsBatchQueryResult(Optional.ToList(responses), error.Value);
        }
    }
}
