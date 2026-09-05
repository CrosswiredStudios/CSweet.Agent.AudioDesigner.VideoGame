using CrosswiredStudios.VideoGame.AgentKit;

namespace CSweet.Agent.AudioDesigner.VideoGame;

public sealed class SpecialistAgent : VideoGameSpecialistAgentBase
{
    public override string AgentId => "com.csweet.video-game-audio-designer";
    public override string Version => "2.1.1";
    protected override string RoleKey => "audio-designer";
    protected override string ArtifactTypeKey => "video-game.audio-bible.v1";
    protected override string RolePrompt => "Own audio direction, SFX, music and VO assets or briefs, implementation metadata, loudness, looping, mixing, and audio accessibility. Record rights and generation provenance.";
    protected override IReadOnlyList<string> RequiredSections => ["Audio Pillars", "SFX", "Music", "Voice", "Implementation Metadata", "Loudness and Mixing", "Accessibility", "Rights and Provenance"];
}
