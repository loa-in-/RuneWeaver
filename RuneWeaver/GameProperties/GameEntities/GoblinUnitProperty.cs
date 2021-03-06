﻿using RuneWeaver.GameProperties.GameEntities.UnitActions;

namespace RuneWeaver.GameProperties.GameEntities
{
    public class GoblinUnitProperty : BasicUnitProperty
    {
        /// <summary>
        /// Fired when entity is spawned.
        /// </summary>
        public override void OnSpawn()
        {
            Name = "Goblin";
            Size = 24;
            MaxHealth = 25;
            Resistance = 12;
            Stability = 8;
            MaxEnergy = 5;
            base.OnSpawn();
            AddActions();
        }

        /// <summary>
        /// Adds the default actions for this entity.
        /// </summary>
        private void AddActions()
        {
            Entity.AddProperties(new MoveActionProperty()
            {
                Name = "March",
                Cost = 1,
                MaxDistance = 3,
                Speed = 1
            });
        }
    }
}
