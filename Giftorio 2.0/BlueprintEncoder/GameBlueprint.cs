﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using BlueprintEncoder;
//
//    var gameBlueprint = GameBlueprint.FromJson(jsonString);

namespace BlueprintEncoder
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GameBlueprint
    {
        [JsonProperty( "blueprint", Required = Required.Always )]
        public Blueprint Blueprint { get; set; }
    }

    public partial class Blueprint
    {
        [JsonProperty( "icons", Required = Required.Always )]
        public List<Icon> Icons { get; set; }

        [JsonProperty( "entities", Required = Required.Always )]
        public List<Entity> Entities { get; set; }

        [JsonProperty( "tiles", Required = Required.Always )]
        public List<Tile> Tiles { get; set; }

        [JsonProperty( "item", Required = Required.Always )]
        public string Item { get; set; }

        [JsonProperty( "label", Required = Required.Always )]
        public string Label { get; set; }

        [JsonProperty( "version", Required = Required.Always )]
        public long Version { get; set; }
    }

    public partial class Entity
    {
        [JsonProperty( "entity_number", Required = Required.Always )]
        public long EntityNumber { get; set; }

        [JsonProperty( "name", Required = Required.Always )]
        public string Name { get; set; }

        [JsonProperty( "position", Required = Required.Always )]
        public Position Position { get; set; }

        [JsonProperty( "direction", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public long? Direction { get; set; }

        [JsonProperty( "control_behavior", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public ControlBehavior ControlBehavior { get; set; }

        [JsonProperty( "connections", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Dictionary<string, Connection> Connections { get; set; }

        [JsonProperty( "parameters", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Parameters Parameters { get; set; }

        [JsonProperty( "alert_parameters", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public AlertParameters AlertParameters { get; set; }
    }

    public partial class AlertParameters
    {
        [JsonProperty( "show_alert", Required = Required.Always )]
        public bool ShowAlert { get; set; }

        [JsonProperty( "show_on_map", Required = Required.Always )]
        public bool ShowOnMap { get; set; }

        [JsonProperty( "alert_message", Required = Required.Always )]
        public string AlertMessage { get; set; }
    }

    public partial class Connection
    {
        [JsonProperty( "red", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public List<ColoredConnection> Red { get; set; }

        [JsonProperty( "green", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public List<ColoredConnection> Green { get; set; }
    }

    public partial class ColoredConnection
    {
        [JsonProperty( "entity_id", Required = Required.Always )]
        public long EntityId { get; set; }

        [JsonProperty( "circuit_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public long? CircuitId { get; set; }
    }

    public partial class ControlBehavior
    {
        [JsonProperty( "filters", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public List<Filter> Filters { get; set; }

        [JsonProperty( "arithmetic_conditions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public ArithmeticConditions ArithmeticConditions { get; set; }

        [JsonProperty( "decider_conditions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public DeciderConditions DeciderConditions { get; set; }

        [JsonProperty( "circuit_condition", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public CircuitCondition CircuitCondition { get; set; }

        [JsonProperty( "circuit_parameters", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public CircuitParameters CircuitParameters { get; set; }

        [JsonProperty( "is_on", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public bool? IsOn { get; set; }
    }

    public partial class ArithmeticConditions
    {
        [JsonProperty( "first_signal", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Signal FirstSignal { get; set; }

        [JsonProperty( "second_constant", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public long? SecondConstant { get; set; }

        [JsonProperty( "operation", Required = Required.Always )]
        public string Operation { get; set; }

        [JsonProperty( "output_signal", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Signal OutputSignal { get; set; }

        [JsonProperty( "second_signal", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Signal SecondSignal { get; set; }

        [JsonProperty( "first_constant", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public long? FirstConstant { get; set; }
    }

    public partial class Signal
    {
        [JsonProperty( "type", Required = Required.Always )]
        public string Type { get; set; }

        [JsonProperty( "name", Required = Required.Always )]
        public string Name { get; set; }
    }

    public partial class CircuitCondition
    {
        [JsonProperty( "first_signal", Required = Required.Always )]
        public Signal FirstSignal { get; set; }

        [JsonProperty( "constant", Required = Required.Always )]
        public long Constant { get; set; }

        [JsonProperty( "comparator", Required = Required.Always )]
        public string Comparator { get; set; }
    }

    public partial class CircuitParameters
    {
        [JsonProperty( "signal_value_is_pitch", Required = Required.Always )]
        public bool SignalValueIsPitch { get; set; }

        [JsonProperty( "instrument_id", Required = Required.Always )]
        public long InstrumentId { get; set; }

        [JsonProperty( "note_id", Required = Required.Always )]
        public long NoteId { get; set; }
    }

    public partial class DeciderConditions
    {
        [JsonProperty( "first_signal", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Signal FirstSignal { get; set; }

        [JsonProperty( "second_signal", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Signal SecondSignal { get; set; }

        [JsonProperty( "comparator", Required = Required.Always )]
        public string Comparator { get; set; }

        [JsonProperty( "output_signal", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public Signal OutputSignal { get; set; }

        [JsonProperty( "copy_count_from_input", Required = Required.Always )]
        public bool CopyCountFromInput { get; set; }

        [JsonProperty( "constant", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore )]
        public long? Constant { get; set; }
    }

    public partial class Filter
    {
        [JsonProperty( "signal", Required = Required.Always )]
        public Signal Signal { get; set; }

        [JsonProperty( "count", Required = Required.Always )]
        public long Count { get; set; }

        [JsonProperty( "index", Required = Required.Always )]
        public long Index { get; set; }
    }

    public partial class Parameters
    {
        [JsonProperty( "playback_volume", Required = Required.Always )]
        public double PlaybackVolume { get; set; }

        [JsonProperty( "playback_globally", Required = Required.Always )]
        public bool PlaybackGlobally { get; set; }

        [JsonProperty( "allow_polyphony", Required = Required.Always )]
        public bool AllowPolyphony { get; set; }
    }

    public partial class Position
    {
        [JsonProperty( "x", Required = Required.Always )]
        public double X { get; set; }

        [JsonProperty( "y", Required = Required.Always )]
        public double Y { get; set; }
    }

    public partial class Icon
    {
        [JsonProperty( "signal", Required = Required.Always )]
        public Signal Signal { get; set; }

        [JsonProperty( "index", Required = Required.Always )]
        public long Index { get; set; }
    }

    public partial class Tile
    {
        [JsonProperty( "position", Required = Required.Always )]
        public Position Position { get; set; }

        [JsonProperty( "name", Required = Required.Always )]
        public string Name { get; set; }
    }

    public partial class GameBlueprint
    {
        public static GameBlueprint FromJson( string json ) => JsonConvert.DeserializeObject<GameBlueprint>( json, BlueprintEncoder.Converter.Settings );
    }

    public static class Serialize
    {
        public static string ToJson( this GameBlueprint self ) => JsonConvert.SerializeObject( self, BlueprintEncoder.Converter.Settings );
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
