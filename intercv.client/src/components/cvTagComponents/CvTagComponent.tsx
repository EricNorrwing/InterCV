
interface CvTagProps {
    tags: string[];
}

export default function CvTagComponent({ tags }: CvTagProps) {
    return (
        <div className="d-flex flex-wrap gap-2">
            {tags.map((tag, index) => (
                <span
                    key={index}
                    className="badge bg-primary"
                    aria-label={`Tag: ${tag}`}
                >
          {tag}
        </span>
            ))}
        </div>
    );
}