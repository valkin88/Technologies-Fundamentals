<?php

/* article/create.html.twig */
class __TwigTemplate_5069cc6fbd7d883f636071beeb85d5bb02b7820deddf378f1d39bffe8d5bb9ff extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "article/create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_0ed76dfb925a1dbba8dc32b62d4840da9e385e5f6a47212043b27549bdb45375 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0ed76dfb925a1dbba8dc32b62d4840da9e385e5f6a47212043b27549bdb45375->enter($__internal_0ed76dfb925a1dbba8dc32b62d4840da9e385e5f6a47212043b27549bdb45375_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "article/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_0ed76dfb925a1dbba8dc32b62d4840da9e385e5f6a47212043b27549bdb45375->leave($__internal_0ed76dfb925a1dbba8dc32b62d4840da9e385e5f6a47212043b27549bdb45375_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_ec2b8e25b5b2a86536693f57a1d6f6077b470f26e9e4adf258ccfb4dc8344ca5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ec2b8e25b5b2a86536693f57a1d6f6077b470f26e9e4adf258ccfb4dc8344ca5->enter($__internal_ec2b8e25b5b2a86536693f57a1d6f6077b470f26e9e4adf258ccfb4dc8344ca5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-horizontal\" action=\"";
        // line 6
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("article_create");
        echo "\" method=\"POST\">
                <fieldset>
                    <legend>New Post</legend>

                    <div class=\"form-group\">
                        <label class=\"col-sm-4 control-label\" for=\"article_title\">Post Title</label>
                        <div class=\"col-sm-4\">
                            <input type=\"text\" class=\"form-control\" id=\"article_title\" placeholder=\"Post Title\" name=\"article[title]\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <label class=\"col-sm-4 control-label\" for=\"article_content\">Content</label>
                        <div class=\"col-sm-6\">
                            <textarea class=\"form-control\" rows=\"6\" id=\"article_content\" name=\"article[content]\"></textarea>
                        </div>
                    </div>

                    ";
        // line 24
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\FormExtension')->renderer->searchAndRenderBlock($this->getAttribute((isset($context["form"]) ? $context["form"] : $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <a class=\"btn btn-default\" href=\"";
        // line 28
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("blog_index");
        echo "\">Cancel</a>
                            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>

";
        
        $__internal_ec2b8e25b5b2a86536693f57a1d6f6077b470f26e9e4adf258ccfb4dc8344ca5->leave($__internal_ec2b8e25b5b2a86536693f57a1d6f6077b470f26e9e4adf258ccfb4dc8344ca5_prof);

    }

    public function getTemplateName()
    {
        return "article/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  72 => 28,  65 => 24,  44 => 6,  40 => 4,  34 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends 'base.html.twig' %}

{% block main %}
    <div class=\"container body-content span=8 offset=2\">
        <div class=\"well\">
            <form class=\"form-horizontal\" action=\"{{ path('article_create') }}\" method=\"POST\">
                <fieldset>
                    <legend>New Post</legend>

                    <div class=\"form-group\">
                        <label class=\"col-sm-4 control-label\" for=\"article_title\">Post Title</label>
                        <div class=\"col-sm-4\">
                            <input type=\"text\" class=\"form-control\" id=\"article_title\" placeholder=\"Post Title\" name=\"article[title]\">
                        </div>
                    </div>

                    <div class=\"form-group\">
                        <label class=\"col-sm-4 control-label\" for=\"article_content\">Content</label>
                        <div class=\"col-sm-6\">
                            <textarea class=\"form-control\" rows=\"6\" id=\"article_content\" name=\"article[content]\"></textarea>
                        </div>
                    </div>

                    {{ form_row(form._token) }}

                    <div class=\"form-group\">
                        <div class=\"col-sm-4 col-sm-offset-4\">
                            <a class=\"btn btn-default\" href=\"{{ path('blog_index') }}\">Cancel</a>
                            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
    </div>

{% endblock %}";
    }
}
