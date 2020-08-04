using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueprintEncoder
{
    public partial class GameBlueprint
    {
        public long EntitiesCount = 0;

        public Entity NewEntity()
        {
            Entity entity = new Entity();
            this.EntitiesCount++;
            entity.EntityNumber = EntitiesCount;
            this.Blueprint.Entities.Add( entity );

            return entity;
        }
    }

    public partial class Entity
    {
        public void ConnectToEntity( long selfPort, ConnectionColor color, Entity other, long otherPort )
        {
            string selfPortS = selfPort.ToString();
            string otherPortS = otherPort.ToString();

            if ( this.Connections == null )
                this.Connections = new Dictionary<string, Connection>();
            if ( other.Connections == null )
                other.Connections = new Dictionary<string, Connection>();

            if ( !this.Connections.ContainsKey( selfPortS ) )
                this.Connections.Add( selfPortS, new Connection() );
            if ( !other.Connections.ContainsKey( otherPortS ) )
                other.Connections.Add( otherPortS, new Connection() );

            if( color == ConnectionColor.Red )
            {
                if ( this.Connections[ selfPortS ].Red == null )
                    this.Connections[ selfPortS ].Red = new List<ColoredConnection>();
                if ( other.Connections[ otherPortS ].Red == null )
                    other.Connections[ otherPortS ].Red = new List<ColoredConnection>();

                this.Connections[ selfPortS ].Red.Add( new ColoredConnection { EntityId = other.EntityNumber, CircuitId = otherPort } );
                other.Connections[ otherPortS ].Red.Add( new ColoredConnection { EntityId = this.EntityNumber, CircuitId = selfPort } );
            }
            else
            {
                if ( this.Connections[ selfPortS ].Green == null )
                    this.Connections[ selfPortS ].Green = new List<ColoredConnection>();
                if ( other.Connections[ otherPortS ].Green == null )
                    other.Connections[ otherPortS ].Green = new List<ColoredConnection>();

                this.Connections[ selfPortS ].Green.Add( new ColoredConnection { EntityId = other.EntityNumber, CircuitId = otherPort } );
                other.Connections[ otherPortS ].Green.Add( new ColoredConnection { EntityId = this.EntityNumber, CircuitId = selfPort } );
            }
        }
    }
}