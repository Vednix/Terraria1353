﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.CustomSoundStyle
// Assembly: TerrariaServer, Version=1.3.5.3, Culture=neutral, PublicKeyToken=null
// MVID: 8A63A7A2-328D-424C-BC9D-BF23F93646F7
// Assembly location: H:\Steam\steamapps\common\Terraria\TerrariaServer.exe

using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
  public class CustomSoundStyle : SoundStyle
  {
    private static UnifiedRandom _random = new UnifiedRandom();
    private SoundEffect[] _soundEffects;

    public override bool IsTrackable
    {
      get
      {
        return true;
      }
    }

    public CustomSoundStyle(SoundEffect soundEffect, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0.0f)
      : base(volume, pitchVariance, type)
    {
      this._soundEffects = new SoundEffect[1]{ soundEffect };
    }

    public CustomSoundStyle(SoundEffect[] soundEffects, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0.0f)
      : base(volume, pitchVariance, type)
    {
      this._soundEffects = soundEffects;
    }

    public override SoundEffect GetRandomSound()
    {
      return this._soundEffects[CustomSoundStyle._random.Next(this._soundEffects.Length)];
    }
  }
}
