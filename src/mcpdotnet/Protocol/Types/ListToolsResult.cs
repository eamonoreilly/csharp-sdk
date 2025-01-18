﻿using McpDotNet.Protocol.Messages;

namespace McpDotNet.Protocol.Types;

/// <summary>
/// A response to a request to list the tools available on the server.
/// <see href="https://github.com/modelcontextprotocol/specification/blob/main/schema/schema.json">See the schema for details</see>
/// </summary>
public class ListToolsResult : PaginatedResult
{
    /// <summary>
    /// The server's response to a tools/list request from the client.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("tools")]
    public List<Tool> Tools { get; set; } = new();
}
