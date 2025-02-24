namespace TheGreatAdventureGame.Models
{
    public class Vital
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public bool IsDepleted
        {
            get
            {
                return this.CurrentHP < 1;
            }
        }

        public Vital(int maxHP)
        {
            this.CurrentHP = maxHP;
            this.MaxHP = maxHP;
        }

        public void Add(int num)
        {
            this.CurrentHP += num;
            if(this.CurrentHP > this.MaxHP)
            {
                this.CurrentHP = this.MaxHP;
            }
        }
        public void Subtract(int num)
        {
            this.CurrentHP -= num;
            if(this.CurrentHP < 0)
            {
                this.CurrentHP = 0;
            }
        }
        public void Deplete()
        {
            this.CurrentHP = 0;
        }
        public void Reset()
        {
            this.CurrentHP = this.MaxHP;
        }
        public override string ToString()
        {
            return $"{CurrentHP}/{MaxHP}";
        }
    }
}
