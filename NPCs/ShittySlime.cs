using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShittyDestruction.NPCs
{
	public class ShittySlime : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shitty Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}
		
		public override void SetDefaults() {
			npc.width = 32;
			npc.height = 32;
			npc.damage = 100;
			npc.defense = 50;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 10000f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			npc.knockBackResist = 0.2f;
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.hardMode);
			{
				return spawnInfo.spawnTileType == TileID.Mud ||spawnInfo.spawnTileType == TileID.Dirt ? .5f : 0f;
			}
		}
		public override void NPCLoot() {
			Item.NewItem(npc.getRect(), ItemID.Gel);
			if (Main.rand.NextFloat() < .8f) {
				Item.NewItem(npc.getRect(), ItemID.Gel);
			}
			if (Main.rand.NextFloat() < .6f) {
				Item.NewItem(npc.getRect(), ItemID.Gel);
			}
			if (Main.rand.NextFloat() < .4f) {
				Item.NewItem(npc.getRect(), ItemID.Gel);
			}
			if (Main.rand.NextFloat() < .2f) {
				Item.NewItem(npc.getRect(), ItemID.Gel);
			}
		}
	}
}
