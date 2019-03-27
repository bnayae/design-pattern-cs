using Autofac.Features.Indexed;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class ShapeTreeBuilder : IShapeTreeBuilder
    {
        private readonly IIndex<Keys, IShape> _mapper;
        private readonly ShapeNode _data;

        public ShapeTreeBuilder(IIndex<Keys, IShape> mapper)
        {
            _mapper = mapper;
            _data = new ShapeNode();
        }
        private ShapeTreeBuilder(ShapeNode data, IIndex<Keys, IShape> mapper)
        {
            _mapper = mapper;
            _data = data;
        }


        public IShapeTreeBuilder AddChild(Keys key)
        {
            IShape child = _mapper[key];
            ShapeNode immutableNode = _data.AddChild(child);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }

        public IShapeTreeBuilder AddNext(Keys key)
        {
            IShape next = _mapper[key];
            ShapeNode immutableNode = _data.SetNext(next);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }
    }
}