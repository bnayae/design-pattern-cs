using Autofac.Features.Indexed;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class ShapeTreeBuilder
    {
        private readonly IIndex<string, IShape> _mapper;

        public ShapeTreeBuilder(IIndex<string, IShape> mapper)
        {
            _mapper = mapper;
        }

        public ShapeTreeBuilder AddChild(string key)
        {
        }
        public ShapeTreeBuilder AddNext(string key)
        {
        }
    }
}