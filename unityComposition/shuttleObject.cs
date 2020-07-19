namespace unityComposition
{
    class shuttleObject
    {
        interfaceShuttleColor color;
        interfaceShuttleType type;
        InterfaceSpeed speed;

        public shuttleObject(interfaceShuttleColor color, interfaceShuttleType type, InterfaceSpeed speed)
        {
            this.color = color;
            this.type = type;
            this.speed = speed;
        }

        public void whatType()
        {
            type.Type();
        }

        public void whatColor()
        {
            color.Color();
        }

        public void whatSpeed()
        {
            speed.Speed();
        }

        public void whatTypeColorSpeed()
        {
            type.Type();
            color.Color();
            speed.Speed();
        }

    }
}
