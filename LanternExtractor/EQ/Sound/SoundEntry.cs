﻿namespace LanternExtractor.EQ.Sound
{
    /// <summary>
    /// Contains information about a single sound instance in the world
    /// Big thanks to Shendare from the EQEmu forums for sharing this information
    /// More documentation will come as I verify all of this info
    /// </summary>
    public class SoundEntry
    {
        public EmissionType EmissionType { get; set; }
        public int UnkRef00 { get; set; }
        public int UnkRef04 { get; set; }
        public int Reserved { get; set; }
        public int Sequence { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Radius { get; set; }
        public int CooldownDay { get; set; }
        public int CooldownNight { get; set; }
        public int RandomDelay { get; set; }
        public int Unk44 { get; set; }
        public string SoundIdDay { get; set; }
        public string SoundIdNight { get; set; }
        public SoundType SoundType { get; set; }
        public byte UnkPad57 { get; set; }
        public byte UnkPad58 { get; set; }
        public byte UnkPad59 { get; set; }
        public int AsDistance { get; set; }
        public int UnkRange64 { get; set; }
        public int FadeOutMs { get; set; }
        public int UnkRange72 { get; set; }
        public int FullVolRange { get; set; }
        public int UnkRange80 { get; set; }
    }
}