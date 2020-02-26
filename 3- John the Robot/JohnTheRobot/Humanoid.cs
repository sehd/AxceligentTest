namespace JohnTheRobot
{
    internal class Humanoid
    {
        private readonly ISkill skill;

        public Humanoid(ISkill skill = null)
        {
            this.skill = skill;
        }

        internal string ShowSkill()
        {
            return skill?.Name ?? "no skill is defined";
        }
    }
}