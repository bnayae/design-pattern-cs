using Autofac.Features.Indexed;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class ShapeTreeBuilder : IShapeTreeBuilder
    {
        private readonly IIndex<string, IShape> _mapper;
        private readonly ShapeNode _data;

        public ShapeTreeBuilder(IIndex<string, IShape> mapper)
        {
            _mapper = mapper;
            _data = new ShapeNode();
        }
        private ShapeTreeBuilder(ShapeNode data, IIndex<string, IShape> mapper)
        {
            _mapper = mapper;
            _data = data;
        }


        public IShapeTreeBuilder AddChild(string key)
        {
            IShape child = _mapper[key];
            ShapeNode immutableNode = _data.AddChild(child);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }

        public IShapeTreeBuilder AddNext(string key)
        {
            IShape next = _mapper[key];
            ShapeNode immutableNode = _data.SetNext(next);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }
    }
}