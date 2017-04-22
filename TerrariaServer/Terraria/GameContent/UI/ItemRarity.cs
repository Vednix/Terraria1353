﻿// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.ItemRarity
// Assembly: TerrariaServer, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null
// MVID: C2103E81-0935-4BEA-9E98-4159FC80C2BB
// Assembly location: F:\Steam\steamapps\common\Terraria\TerrariaServer.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;

namespace Terraria.GameContent.UI
{
  public class ItemRarity
  {
    private static Dictionary<int, Color> _rarities = new Dictionary<int, Color>();

    public static void Initialize()
    {
      ItemRarity._rarities.Clear();
      ItemRarity._rarities.Add(-11, Colors.RarityAmber);
      ItemRarity._rarities.Add(-1, Colors.RarityTrash);
      ItemRarity._rarities.Add(1, Colors.RarityBlue);
      ItemRarity._rarities.Add(2, Colors.RarityGreen);
      ItemRarity._rarities.Add(3, Colors.RarityOrange);
      ItemRarity._rarities.Add(4, Colors.RarityRed);
      ItemRarity._rarities.Add(5, Colors.RarityPink);
      ItemRarity._rarities.Add(6, Colors.RarityPurple);
      ItemRarity._rarities.Add(7, Colors.RarityLime);
      ItemRarity._rarities.Add(8, Colors.RarityYellow);
      ItemRarity._rarities.Add(9, Colors.RarityCyan);
    }

    public static Color GetColor(int rarity)
    {
      Color color = new Color((int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor, (int) Main.mouseTextColor);
      if (ItemRarity._rarities.ContainsKey(rarity))
        return ItemRarity._rarities[rarity];
      return color;
    }
  }
}
