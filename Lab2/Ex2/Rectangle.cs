namespace Ex2
{
    internal class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle() { }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool Check(Point point)
        {
            bool isInHorizontal = false;
            if (TopLeft.X < point.X && BottomRight.X > point.X)
            {
                isInHorizontal = true;
            }
            bool isInVertical = false;
            if (TopLeft.Y < point.Y && BottomRight.Y > point.Y)
            {
                isInVertical = true;
            }
            return isInHorizontal && isInVertical;
        }
    }
}
