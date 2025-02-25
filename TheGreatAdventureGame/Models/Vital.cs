namespace TheGreatAdventureGame.Models
{
    public class Vital
    {
        public int Current { get; set; }
        public int Max { get; set; }
        public bool IsDepleted
        {
            get
            {
                return this.Current < 1;
            }
        }
        public bool IsAtMax
        {
            get
            {
                return this.Current >= this.Max;
            }
        }

        public Vital(int maxHP)
        {
            this.Current = maxHP;
            this.Max = maxHP;
        }

        public Vital(int startHP, int maxHP)
        {
            this.Current = startHP;
            this.Max = maxHP;
        }

        /// <summary>
        /// Adds the specified amount to the current value. If the result exceeds the maximum limit, 
        /// the current value is capped at the maximum, and the overflow amount is returned.
        /// </summary>
        /// <param name="num">The amount to add to the current value.</param>
        /// <returns>
        /// The leftover amount if the addition exceeds the maximum limit; otherwise, returns null.
        /// </returns>
        public int? Add(int num)
        {
            this.Current += num;

            int? leftOver = null;
            if(this.Current > this.Max)
            {
                leftOver = this.Current - this.Max; 
                this.Current = this.Max;
                 
            }
            return leftOver;
        }
        public void Subtract(int num)
        {
            this.Current -= num;
            if(this.Current < 0)
            {
                this.Current = 0;
            }
        }
        public void Deplete()
        {
            this.Current = 0;
        }
        public void Reset()
        {
            this.Current = this.Max;
        }
        public override string ToString()
        {
            return $"{Current}/{Max}";
        }
    }
}
