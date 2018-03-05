<?php

/* blog/index.html.twig */
class __TwigTemplate_f7d091b582170cded427f00b5400f7243d309de0b4e605d5450f94f0983ab607 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "blog/index.html.twig", 1);
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
        $__internal_a645ea8a9312005abfa374a685f2390c7698b23063d67e79bc1655cf93216c32 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a645ea8a9312005abfa374a685f2390c7698b23063d67e79bc1655cf93216c32->enter($__internal_a645ea8a9312005abfa374a685f2390c7698b23063d67e79bc1655cf93216c32_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "blog/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_a645ea8a9312005abfa374a685f2390c7698b23063d67e79bc1655cf93216c32->leave($__internal_a645ea8a9312005abfa374a685f2390c7698b23063d67e79bc1655cf93216c32_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_89be6c4930f1ddada674a52a24b8c73c7864d01c5e737d3b450bb5f739dbfb7b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_89be6c4930f1ddada674a52a24b8c73c7864d01c5e737d3b450bb5f739dbfb7b->enter($__internal_89be6c4930f1ddada674a52a24b8c73c7864d01c5e737d3b450bb5f739dbfb7b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div class=\"container body-content\">
        <div class=\"row\">
            ";
        // line 6
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable((isset($context["articles"]) ? $context["articles"] : $this->getContext($context, "articles")));
        foreach ($context['_seq'] as $context["_key"] => $context["article"]) {
            // line 7
            echo "            <div class=\"col-md-6\">
                <article>
                    <header>
                        <h2>";
            // line 10
            echo twig_escape_filter($this->env, $this->getAttribute($context["article"], "title", array()), "html", null, true);
            echo "</h2>
                    </header>

                    <p>
                        ";
            // line 14
            echo twig_escape_filter($this->env, $this->getAttribute($context["article"], "summary", array()), "html", null, true);
            echo "
                    </p>

                    <small class=\"author\">
                        ";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute($context["article"], "author", array()), "html", null, true);
            echo "
                    </small>

                    <footer>
                        <div class=\"pull-right\">
                            <a class=\"btn btn-default btn-xs\" href=\"";
            // line 23
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("article_view", array("id" => $this->getAttribute($context["article"], "id", array()))), "html", null, true);
            echo "\">Read more &raquo;</a>
                        </div>
                    </footer>
                </article>
            </div>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['article'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 29
        echo "        </div>
    </div>

";
        
        $__internal_89be6c4930f1ddada674a52a24b8c73c7864d01c5e737d3b450bb5f739dbfb7b->leave($__internal_89be6c4930f1ddada674a52a24b8c73c7864d01c5e737d3b450bb5f739dbfb7b_prof);

    }

    public function getTemplateName()
    {
        return "blog/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  87 => 29,  75 => 23,  67 => 18,  60 => 14,  53 => 10,  48 => 7,  44 => 6,  40 => 4,  34 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends 'base.html.twig' %}

{% block main %}
    <div class=\"container body-content\">
        <div class=\"row\">
            {% for article in articles %}
            <div class=\"col-md-6\">
                <article>
                    <header>
                        <h2>{{ article.title }}</h2>
                    </header>

                    <p>
                        {{ article.summary }}
                    </p>

                    <small class=\"author\">
                        {{ article.author }}
                    </small>

                    <footer>
                        <div class=\"pull-right\">
                            <a class=\"btn btn-default btn-xs\" href=\"{{ path('article_view', {'id': article.id}) }}\">Read more &raquo;</a>
                        </div>
                    </footer>
                </article>
            </div>
            {% endfor %}
        </div>
    </div>

{% endblock %}
";
    }
}
